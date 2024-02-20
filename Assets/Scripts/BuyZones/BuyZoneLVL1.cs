using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyZoneLVL1 : MonoBehaviour
{
    public GameObject txt;
    public Transform player;

    private void Start()
    {
        txt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            txt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (player)
        {
            txt.SetActive(false);
        }
    }
}
