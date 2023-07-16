using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Initialize speed variable
    private float speed = 15.0f;
    //Initialize left and right speed variable
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move vehicle with left and right keys
        horizontalInput = Input.GetAxis("Horizontal");
        //move vehicle with forward and backwards keys
        forwardInput = Input.GetAxis("Vertical");

        //move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //move vehicle left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
