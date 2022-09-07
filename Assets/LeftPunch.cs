using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPunch : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressed = Input.GetButton("Left Punch");
        anim.SetBool("Left Punch", isPressed);
    }
}
