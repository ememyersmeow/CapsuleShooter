using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    public Transform player;
    public Enemy enemy;

    void Update()
    {
        if(enemy.distanceToPlayer <= enemy.detectionRange)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20 * Time.deltaTime);
        }
    }
}
