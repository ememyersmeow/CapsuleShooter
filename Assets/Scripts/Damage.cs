using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            HPplayer.HP -= damage;
        }
    }
}
