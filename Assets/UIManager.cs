using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider healthbar;
    [SerializeField] private Image healthfill;
    public void SetInitialHealth(int maxHealth)
    {
        healthbar.maxValue = maxHealth;
        healthbar.value = maxHealth;
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
