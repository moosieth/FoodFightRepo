using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{

    private int damage = 3;
    private int throwDamage = 2;
    private bool isDuelWielding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetDamage(){
        return damage;
    }

    public int GetThrowDamage(){
        return throwDamage;
    }

    public bool CheckDuelWield(){
        return isDuelWielding;
    }

    public void SetDuelWield(bool isDuelWielding){
        this.isDuelWielding = isDuelWielding;
    }

    public void DuelEffect(){
        if (isDuelWielding = true){
            damage = 6;
        }
        else
            damage = 3;
        
    }
    
}
