using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true && Input.GetKeyDown(KeyCode.E))
        {

            Destroy(gameObject);
        }

        if (other.CompareTag("Player") == true)
        {

            other.GetComponent<Player>().points += 1;
        }
    }

        


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
