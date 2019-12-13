using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public GameObject[] DuckList;

    public void Spawn(GameObject go)
    {
        Instantiate(DuckList[UnityEngine.Random.Range(0, DuckList.Length)], go.transform.position,new Quaternion(0f,0f,0f,0f)).GetComponent<MoveDuck>().currentSpawn = go.gameObject;
    }
}
