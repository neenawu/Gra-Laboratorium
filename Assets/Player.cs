using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 0;
    public int maxhealth = 10;
    public int coins = 0;
    public int points = 0;
    public float Szybkosæ = 2.5f;
    public CharacterController controller;
    public Vector3 movement;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {

        ;
        


        movement.z = -Input.GetAxis("Horizontal");


        movement.x = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))


            {
                movement.y = 3f;
            }
        }
        else
        {
            movement.y -= 0.01f;
        }
        direction = movement;
        direction.y = 0;
        if (direction.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

    }

    void FixedUpdate()
    {
        controller.Move(movement * Time.fixedDeltaTime * Szybkosæ);


    }
}
