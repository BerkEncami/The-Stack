using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBG : MonoBehaviour
{
    [SerializeField] Sprite[] bgs=new Sprite[7];
    SpriteRenderer spriteRenderer;
    int index;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        randomIndex();
    }

    void randomIndex()
    {
        index = Random.Range(0, 7);
        spriteRenderer.sprite = bgs[index];
    }


    
}
