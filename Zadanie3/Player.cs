using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Szybkosæ = 2.5f;
    public CharacterController controller;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {

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
    }

    void FixedUpdate()
    {
        controller.Move(movement * Time.fixedDeltaTime * Szybkosæ);
        
       
    }
}
