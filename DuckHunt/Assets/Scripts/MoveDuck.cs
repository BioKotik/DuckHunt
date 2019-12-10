using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour
{
    public GameObject[] SpawnList;
    Vector3 direction;
    Rigidbody2D rb;
    private Animator animator;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        int rand = UnityEngine.Random.Range(0,4);
        direction = Vector3.zero;
        switch (rand)
        {
            case 0:
                {
                    direction = new Vector3(1f, 0f, 0f);
                    GetComponent<SpawnDuck>().Spawn(SpawnList[UnityEngine.Random.Range(0,2)]);
                    break;
                }
            case 1:
                {
                    direction = new Vector3(-1f, 0f, 0f);
                    GetComponent<SpawnDuck>().Spawn(SpawnList[UnityEngine.Random.Range(2, 4)]);
                    break;
                }
            case 2:
                {
                    direction = new Vector3(1f, 1f, 0f);
                    GetComponent<SpawnDuck>().Spawn(SpawnList[4]);
                    break;
                }
            case 3:
                {
                    direction = new Vector3(-1f, 1f, 0f);
                    GetComponent<SpawnDuck>().Spawn(SpawnList[5]);
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
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Background"))
        {
            Destroy(this.gameObject);
            Score.CurrentScore++;
        }
    }
}
