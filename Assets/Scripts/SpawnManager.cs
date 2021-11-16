using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float delay;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject obstacles = Instantiate(obstacle, new Vector3(10, Random.Range(-2f, 2f), 0), Quaternion.identity) as GameObject;
    }
}
