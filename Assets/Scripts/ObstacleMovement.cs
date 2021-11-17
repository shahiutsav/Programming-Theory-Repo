using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float outOfBounds = -10f;
    void Update()
    {
        DestroyOnReachingBoundary();
        MovingObstacles();
    }

    // Moving obstacles in the pathway of the player
    void MovingObstacles()
    {
        transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime;
    }

    // Destroying obstacles when they are off screen
    void DestroyOnReachingBoundary()
    {
        if (gameObject.transform.position.x <= outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
