using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPunch : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool isPressed = Input.GetButton("Right Punch");
        float isHeld = Input.GetAxis("RightPunchRT");

        anim.SetBool("Right Punch", isPressed);


        // if (isPressed || isHeld > .03){
        //     anim.SetBool("Right Punch", true);
        // } 
    }
}
