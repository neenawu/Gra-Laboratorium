using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WygranaAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOMoveX(transform.position.x + 4.0f, 0.25f).SetLoops(3, LoopType.Yoyo);
    }
}
