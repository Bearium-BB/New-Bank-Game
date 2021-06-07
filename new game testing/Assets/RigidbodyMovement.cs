using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    public float maxspeed;
    public float acceleration;
    public float CurrentSpeed;
    bool ifRuning = false;
    Rigidbody rbPlayer;
    float vertical;
    float horizontal;
    public float TimeToStop = 1;
    float StopSpeedx;
    float StopSpeedy;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        solwingdown();
    }
    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            acceleration *= 2;
            ifRuning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) == false && ifRuning == true)
        { 
            acceleration /= 2;
            ifRuning = false;
        }
        vertical = Input.GetAxis("Vertical") * acceleration * Time.deltaTime;
        horizontal = Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        rbPlayer.AddRelativeForce(Vector3.forward * vertical);
        rbPlayer.AddRelativeForce(Vector3.right * horizontal);
        float x;
        float z;
        x = rbPlayer.velocity.x;
        z = rbPlayer.velocity.z;
        if(x <= 0)
        {
            x *= -1;
        }
        if (z <= 0)
        {
            z *= -1;
        }
        CurrentSpeed = x +z;
        if (CurrentSpeed >= maxspeed)
        {
            rbPlayer.velocity = new Vector3(rbPlayer.velocity.x / 9, rbPlayer.velocity.y, rbPlayer.velocity.x / 9 );
        }

    }
    void solwingdown()
    {
        if (CurrentSpeed > 0) 
        {
            if (Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false && Input.GetKey(KeyCode.D) == false && Input.GetKey(KeyCode.A) == false)
            {
                StopSpeedx =  rbPlayer.velocity.x / TimeToStop;
                StopSpeedy =  rbPlayer.velocity.y / TimeToStop;
                rbPlayer.AddForce(StopSpeedx, 0, StopSpeedy, ForceMode.Force);
            }
        }
    }
}
