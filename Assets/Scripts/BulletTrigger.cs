using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    public int bulletPlus = 50;
    private Weapon weapon;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            weapon = other.gameObject.GetComponentInChildren<Weapon>();
            weapon.totalAmmo += bulletPlus;
            weapon.UpdateText();
            Destroy(gameObject);
        }
    }
}
