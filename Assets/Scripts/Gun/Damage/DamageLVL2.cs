using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLVL2 : MonoBehaviour
{
    public int damage = 100;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HPplayerLVL2.HP -= damage;
        }
    }
}
