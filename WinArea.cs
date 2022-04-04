using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;


public class WinArea : MonoBehaviour
{
    public RectTransform winPanel;
    public string SampleScene;
    void Start()
    {
        winPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider enter)
    {
        if (enter.CompareTag("Player")==true) 
        {
            if (enter.GetComponent<Player>().points>=2)
            {
                winPanel.gameObject.SetActive(true);
            }
            
        }
    }

    public void LoadNewLevel()
    {
        SceneManager.LoadScene(SampleScene);
    }
    // Start is called before the first frame update
    

  
}
