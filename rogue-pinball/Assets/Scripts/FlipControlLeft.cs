using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipControlLeft : MonoBehaviour
{
    public bool isKeyPress = false;
    public bool isTouched = false;

    public float speed = 0f;
    private HingeJoint2D hingeJoint2D;
    private JointMotor2D jointMotor;

    void Start()
    {
        hingeJoint2D = GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint2D.motor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isKeyPress = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            isKeyPress = false;
        }
    }

    void FixedUpdate()
    {
        // on press keyboard or touch Screen
        if (isKeyPress == true && isTouched == false || isKeyPress == false && isTouched == true)
        {
            // set the motor speed to max
            jointMotor.motorSpeed = speed;
            hingeJoint2D.motor = jointMotor;
        }
        else
        {
            // snap the motor back again
            jointMotor.motorSpeed = -speed;
            hingeJoint2D.motor = jointMotor;
        }
    }
}
