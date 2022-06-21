using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public Animator LeftaflipperAnimator;
    public Animator RightflipperAnimator;

    //public Rigidbody2D left, right;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftaflipperAnimator.ResetTrigger("Pressed");
            LeftaflipperAnimator.SetTrigger("Pressed");
            //left.AddTorque(25f);
        }
        else
        {
            //left.AddTorque(-20f);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightflipperAnimator.ResetTrigger("Pressed");
            RightflipperAnimator.SetTrigger("Pressed");
            //right.AddTorque(-25f);
        }
        else
        {
            //right.AddTorque(20f);
        }
    }
}
