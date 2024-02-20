using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController2 : MonoBehaviour
{
    public GameObject objectToSwitch;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (player)
        {
            objectToSwitch.SetActive(true);
            Destroy(gameObject);
        } 
    }
}
