using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 1f;
    private float repeatRate = 4f;
    public GameObject obstacle;
    private float randomPosition = 2f;
    private float spawnPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Time delay for repeating the obstacles
        InvokeRepeating("Spawn", startDelay, repeatRate);

    }

    // Instantiating gameObjects at the provided spawnPosition of X-axis and random position of Y-axis
    void Spawn()
    {
        GameObject obstacles = Instantiate(obstacle, new Vector3(spawnPosition, Random.Range(-randomPosition, randomPosition), 0), Quaternion.identity) as GameObject;
    }


}
