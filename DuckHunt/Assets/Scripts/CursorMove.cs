using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMove : MonoBehaviour
{
    public Vector3 mousePosition;
    public float distance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
