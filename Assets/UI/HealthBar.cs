using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    PlayerHealth playerHealth;



    // Start is called before the first frame update
    void Start()
    {
        //healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<UI.Image>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        var healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<PlayerHealth>();
        healthBar.value = playerHealth.value = playerHealth.health;
    }
}
