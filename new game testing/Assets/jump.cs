using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rigidBody;
    public bool isGrounded = true;
    public int jumph  = 0;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rigidBody.AddForce(new Vector3(0, jumph));
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "wall" || collision.gameObject.tag == "door")
        {
            isGrounded = true;

        }

    }

}















 

