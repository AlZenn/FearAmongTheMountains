using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    private float offsetAngle = -90f;
    Vector3 dest;
    private void Update()
    {
        dest = player.position;
        ai.destination = dest;
        Vector3 direction = player.position - transform.position;
        direction.y = 0f; // Keep the enemy aligned with the ground (optional)

        // Rotate the direction by the offset angle
        Quaternion targetRotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0f, -offsetAngle, 0f);

        // Apply the rotation to the enemy
        transform.rotation = targetRotation;
    }
}
