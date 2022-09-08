using System;
using System.Net.Http;
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
    private float requiredDistance;
    public Image pickupDisplay;
    private string foodName;
    private GameObject food;
    GameObject[] foodItem;
    float[] foodLocationX;
    float[] foodLocationY;

    //private bool checked = false;

    // Start is called before the first frame update
    void Start()
    {
        pickupDisplay = GetComponent<Image>();
        pickupDisplay.enabled = true;
        //pickupDisplay = GameObject.FindGameObjectWithTag("Near Item");
        //pickupDisplay.enabled = false;
    }

    private bool wasPressed;
    // Update is called once per frame
    void FixedUpdate()
    {
        bool isPressed = Input.GetButton("Pickup");
        anim.SetBool("Pickup Button", isPressed);

        if (NearFood(3)){
            if (isPressed){
                food.SetActive(false);
                GameObject.FindGameObjectWithTag("Player").SetActive(false);

                switch (foodName){
                    case "banana": GameObject.Find("Player (bananaR)").SetActive(true); break;
                    case "cheese": GameObject.Find("Player (cheeseR)").SetActive(true); break;
                    case "olive": GameObject.Find("Player (oliveR)").SetActive(true); break;
                    case "cherry": GameObject.Find("Player (cherryR)").SetActive(true); break;
                    default: break;
                }
            }
        }
        
    }

    public void checkItem()
    {
        
    }

    private void SetPressed(){

    }

    private bool NearFood(int itemCount){

        for(int i = 0; i <= itemCount; i++){
            foodLocationX[i] = GameObject.FindGameObjectWithTag("FoodItem").transform.position.x;
            foodLocationY[i] = GameObject.FindGameObjectWithTag("FoodItem").transform.position.y;
            foodItem[i] = GameObject.FindGameObjectWithTag("FoodItem");
        }

        //foodLocationX = GameObject.FindGameObjectWithTag("FoodItem").transform.position.x;
        //foodLocationY = GameObject.FindGameObjectWithTag("FoodItem").transform.position.y;

        float playerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        float playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;

        for (int i = 0; i <= itemCount; i++){
            if (playerX < foodLocationX[i] + requiredDistance && playerX > foodLocationX[i]
            - requiredDistance && playerY < foodLocationY[i] + requiredDistance && 
            playerY > foodLocationY[i] - requiredDistance){
                foodName = foodItem[i].GetComponent<FoodItem>().GetName();;
                food = foodItem[i];
                DisplayMessage();
                return true;
            }
        }
        return false;
    }

    private void DisplayMessage(){
        pickupDisplay = GetComponent<Image>();
        pickupDisplay.enabled = true;
        
    }

}
