using System.Diagnostics.Contracts;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 15f;
    public float moveSpeed = 3f;

    public float distanceToPlayer;

    private void Update()
    {
        if (player == null)
        {
            return;
        }

        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20 * Time.deltaTime);

            if (distanceToPlayer > 1f)
            {
               transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
        }
    }
}