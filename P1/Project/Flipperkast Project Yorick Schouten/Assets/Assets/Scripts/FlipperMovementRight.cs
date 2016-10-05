using UnityEngine;
using System.Collections;

public class FlipperMovementRight : MonoBehaviour
{

    private bool pressed = false;
    private object motor;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        if (Input.GetButton("Fire2"))
        {
            HingeJoint hinge = GetComponent<HingeJoint>();
            JointMotor motor = hinge.motor;
            motor.force = 450;
            motor.targetVelocity = 1800;
            motor.freeSpin = false;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        else
        {
            HingeJoint hinge = GetComponent<HingeJoint>();
            JointMotor motor = hinge.motor;
            motor.force = 250;
            motor.targetVelocity = -1500;
            motor.freeSpin = false;
            hinge.motor = motor;
            hinge.useMotor = true;
        }


    }
}

