using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int DistanceAway = 10;
        Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position;
        GameObject.Find("MainCamera").transform.position = 
            new Vector3(PlayerPOS.x + 1, PlayerPOS.y + 8, PlayerPOS.z + 12);
    }
}
