using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public Sprite[] SpriteList;
    private Sprite bullets;
    void Start()
    {
        bullets = this.GetComponent<SpriteRenderer>().sprite;
    }
    
    void Update()
    {
        if (GetComponent<MoveDuck>().BulletCount == 3)
        {
            bullets = SpriteList[0];
        }
        if (GetComponent<MoveDuck>().BulletCount == 2)
        {
            bullets = SpriteList[1];
        }
        if (GetComponent<MoveDuck>().BulletCount == 1)
        {
            bullets = SpriteList[2];
        }
        if (GetComponent<MoveDuck>().BulletCount == 0)
        {
            bullets = SpriteList[3];
        }
    }
}
