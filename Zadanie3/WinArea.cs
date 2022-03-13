using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;


public class WinArea : MonoBehaviour
{
    public string SampleScene; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;
        {
            SceneManager.LoadScene(SampleScene);
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
