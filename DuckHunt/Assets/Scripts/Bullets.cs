using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
<<<<<<< HEAD
    public int bulletCount;
    public Sprite[] SpriteList;
    void Start()
    {
        bulletCount = 3;
=======
    public Sprite[] SpriteList;
    private Sprite bullets;
    void Start()
    {
        bullets = this.GetComponent<SpriteRenderer>().sprite;
>>>>>>> d89a6daf015553c35820015d42e5bed39f314ad0
    }
    
    void Update()
    {
<<<<<<< HEAD
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

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && bulletCount > 0)
        {
            bulletCount--;
        }

        if (Input.GetMouseButtonDown(1))
        {
            bulletCount = 3;
=======
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
>>>>>>> d89a6daf015553c35820015d42e5bed39f314ad0
        }
    }
}
