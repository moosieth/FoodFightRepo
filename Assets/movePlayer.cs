using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    Vector3 pos;
    Vector3 rotation;

    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //rigid body and position
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        pos = rb.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // gets input
        float x_move = Input.GetAxis("Horizontal");
        float y_move = Input.GetAxis("Vertical");

        move(x_move,y_move);

        

    }


    private void move(float x_move, float y_move){
        //New position
        pos.x += x_move * Time.deltaTime * speed;
        pos.z += y_move * Time.deltaTime * speed;
        transform.position = pos; //moves player

        Vector3 movementDirection = new Vector3(x_move, 0, y_move); // gets direction
        movementDirection.Normalize();

        //checks for input
        if (movementDirection != Vector3.zero){
            
            transform.forward = movementDirection; // rotates player
        }

    }
}
