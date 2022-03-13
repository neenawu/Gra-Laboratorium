using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")==true&&Input.GetKeyDown(KeyCode.E))        
        {
            Destroy(gameObject);
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
