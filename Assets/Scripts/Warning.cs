using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Warning : MonoBehaviour
{
    public TMP_Text warningText;
    public Transform player;

    private void OnTriggerStay(Collider other)
    {
        if (player)
        {
            warningText.enabled = true;
        }
        else
        {
            warningText.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (player)
        {
            warningText.enabled = false;
        }
    }
}
        
