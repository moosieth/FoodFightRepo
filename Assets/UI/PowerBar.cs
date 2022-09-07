using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBar : MonoBehaviour
{
    PlayerPower playerPower;

    // Start is called before the first frame update
    void Start()
    {
        
        playerPower = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPower>();
    }

    // Update is called once per frame
    void Update()
    {
        var powerBar = GameObject.FindGameObjectWithTag("PowerBar").GetComponent<PlayerPower>();
        powerBar.value = playerPower.value = playerPower.power;
    }
}