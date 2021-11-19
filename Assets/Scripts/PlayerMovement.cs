using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 2.2f;
    public bool IsFlying = true;

    private int score = 0;

    private GameManager gameManager;

    private ObstacleMovement obstacleMovement;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsFlying)
        {
            m_Rigidbody.velocity = Vector3.up * m_Thrust;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsFlying = false;
        gameManager.ShowGameOver();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.UpdateScore();
        Debug.Log("Score point triggered");
    }
}
