using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int[] foods = new int[7];

    //  0 = olive
    //  1 = cherry
    //  2 = banana
    //  3 = cheese
    //  4 = watermelon


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickup(FoodItem item)
    {
        switch (item.GetName()){
            case "Olive": foods[0]++ ; break;
            case "Cherry": foods[1]++ ; break;
            case "banana": foods[2]++ ; break;
            case "cheese": foods[3]++ ; break;
            case "watermelon": foods[4]++; break;
            case "hotDog": foods[5]++; break;
            case "hamburger": foods[6]++; break;
            default: break;
        }


    }
}
