using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public GameObject[] DuckList;

    public void Spawn(GameObject go)
    {
<<<<<<< HEAD
        Instantiate(DuckList[UnityEngine.Random.Range(0, DuckList.Length)], go.transform.position,new Quaternion(0f,0f,0f,0f)).GetComponent<MoveDuck>().currentSpawn = go.gameObject;
    //    this.gameObject.SetActive(false);
=======
        Instantiate(DuckList[UnityEngine.Random.Range(0, DuckList.Length)], go.transform.position,new Quaternion(0f,0f,0f,0f));
>>>>>>> d89a6daf015553c35820015d42e5bed39f314ad0
    }
}
