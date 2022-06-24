using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public Animator PalancaAnimator;
    

    //public Rigidbody2D left, right;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            PalancaAnimator.ResetTrigger("Pressed");
            PalancaAnimator.SetTrigger("Pressed");
            //left.AddTorque(25f);
        }
        //else
        //{
        //    //left.AddTorque(-20f);
        //}

        //if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    RightflipperAnimator.ResetTrigger("Pressed");
        //    RightflipperAnimator.SetTrigger("Pressed");
        //    //right.AddTorque(-25f);
        //}
        //else
        //{
        //    //right.AddTorque(20f);
        //}
    }
}
