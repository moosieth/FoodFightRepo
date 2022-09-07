using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{

    private int damage = 0;
    private string name = "yes";

    // Start is called before the first frame update
    void Start()
    {
        //foodItem = GetComponent<FoodItem>();
    }

    // Update is called once per frame
    void Update()
    {
        //setDamage(foodItem);
    }

    public string GetName(){
        return this.name;
    }

    public int GetDamage(){
        return this.damage;
    }

    // public int setDamage(FoodItem foodItem){
    //     switch(foodItem){
    //         case "Hamburger": damage = 0; break;
    //         case "Hotdog": damage = 0; break;
    //         case "banana": damage = 3; break;
    //         case "cheese": damage = 4; break;
    //     }
    // }


}
