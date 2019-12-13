﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour
{
    public int BulletCount;
    public GameObject[] SpawnList;
    Vector3 direction;
    Rigidbody2D rb;
    private Animator animator;
    public float speed = 1;
    public GameObject currentSpawn;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        direction = Vector3.zero;
        switch (currentSpawn.transform.position.x)
        {
            case 0:
                {
                    direction = new Vector3(1f, 0f, 0f);
                    break;
                }
            case 1:
                {
                    direction = new Vector3(-1f, 0f, 0f);
                    break;
                }
            case 2:
                {
                    direction = new Vector3(1f, 1f, 0f);
                    break;
                }
            case 3:
                {
                    direction = new Vector3(-1f, 1f, 0f);
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("MoveX", direction.x);
        animator.SetFloat("MoveY", direction.y);
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0) && collision.gameObject.CompareTag("Scope"))
        {
            direction = new Vector3(0f, -1f, 0f);
            BulletCount--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Background"))
        {
            int rand = UnityEngine.Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    {
                        GetComponent<SpawnDuck>().Spawn(SpawnList[UnityEngine.Random.Range(0, 2)]);
                        break;
                    }
                case 1:
                    {
                        GetComponent<SpawnDuck>().Spawn(SpawnList[UnityEngine.Random.Range(2, 4)]);
                        break;
                    }
                case 2:
                    {
                        GetComponent<SpawnDuck>().Spawn(SpawnList[4]);
                        break;
                    }
                case 3:
                    {
                        GetComponent<SpawnDuck>().Spawn(SpawnList[5]);
                        break;
                    }
            }
            Destroy(this.gameObject);
            Score.CurrentScore++;
        }
    }
}
