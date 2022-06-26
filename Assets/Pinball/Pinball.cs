using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    public float speed = 0f;
    public HingeJoint2D hingeJoint2DLeft;
    private JointMotor2D jointMotorLeft;

    public HingeJoint2D hingeJoint2DRight;
    private JointMotor2D jointMotorRight;

    private void Start()
    {
        jointMotorLeft = hingeJoint2DLeft.motor;

        jointMotorRight = hingeJoint2DRight.motor;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            jointMotorLeft.motorSpeed = -speed;
            hingeJoint2DLeft.motor = jointMotorLeft;
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            jointMotorLeft.motorSpeed = speed;
            hingeJoint2DLeft.motor = jointMotorLeft;
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            jointMotorRight.motorSpeed = speed;
            hingeJoint2DRight.motor = jointMotorRight;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            jointMotorRight.motorSpeed = -speed;
            hingeJoint2DRight.motor = jointMotorRight;
        }
    }
}
