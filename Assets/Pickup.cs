using System.Runtime.ConstrainedExecution;
using System.Globalization;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    Image image;
    public Animator anim;
    private Rigidbody rb;
    private int requiredDistance;
    public Image pickupDisplay;

    //private bool checked = false;

    // Start is called before the first frame update
    void Start()
    {
        pickupDisplay = GetComponent<Image>();
        pickupDisplay.enabled = false;
        //pickupDisplay = GameObject.FindGameObjectWithTag("Near Item");
        //pickupDisplay.enabled = false;
    }

    private bool wasPressed;
    // Update is called once per frame
    void FixedUpdate()
    {
        NearFood();
        bool isPressed = Input.GetButton("Pickup");
        anim.SetBool("Pickup Button", isPressed);
        
    }

    public void checkItem()
    {
        
    }

    private void SetPressed(){

    }

    private bool NearFood(){
        float foodLocationX = GameObject.FindGameObjectWithTag("FoodItem").transform.position.x;
        float foodLocationY = GameObject.FindGameObjectWithTag("FoodItem").transform.position.y;

        float playerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        float playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;

        if (playerX < foodLocationX + requiredDistance && playerX > foodLocationX
            - requiredDistance && playerY < foodLocationY + requiredDistance && 
            playerY > foodLocationY - requiredDistance){
                DisplayMessage();
                return true;
            }
        else
            return false;
    }

    private void DisplayMessage(){
        pickupDisplay = GetComponent<Image>();
        pickupDisplay.enabled = true;
        
    }

}
