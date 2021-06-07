using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3D : MonoBehaviour
{

    public float speedr = 10.0f;
    private float translation;
    private float straffe;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speedr * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speedr * Time.deltaTime;
        transform.Translate(straffe, 0, translation);
    }
}
