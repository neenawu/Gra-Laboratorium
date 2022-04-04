using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    public Renderer renderer;
    public int prize = 1;
    private bool collected = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true && collected == false)
        {
            collected = true;
            //Destroy(this.gameObject);
            transform.DOMoveY(transform.position.y + 2.0f, 1.0f).SetLoops(-1, LoopType.Yoyo);
            transform.DOScale(transform.localScale * 0.5f, 1.0f);
            renderer.material.DOFade(0, 1.0f)
                .OnComplete(() =>
                {
                    Destroy(gameObject);
                });
            other.GetComponent<Player>().points += prize;
        }


    }

}