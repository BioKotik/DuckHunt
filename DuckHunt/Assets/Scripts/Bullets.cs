using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public int bulletCount;
    public Sprite[] SpriteList;
    void Start()
    {
        bulletCount = 3;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletCount > 0)
        {
            bulletCount--;
        }

        if (Input.GetMouseButtonDown(1))
        {
            bulletCount = 3;
        }

        if (bulletCount == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteList[0];
        }
        if (bulletCount == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteList[1];
        }
        if (bulletCount == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteList[2];
        }
        if (bulletCount == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteList[3];
        }
    }
}
