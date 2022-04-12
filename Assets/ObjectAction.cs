using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
            transform.DOScale(transform.localScale * 2f, 0.25f);
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
