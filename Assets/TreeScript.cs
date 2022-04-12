using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.F;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            if(Input.GetKey(interactionKey))
            {
                Destroy(this.gameObject);
            }
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
