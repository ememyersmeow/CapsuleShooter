using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL2i1 : MonoBehaviour
{
    private int keyValue = 0;
    public TMP_Text keyText;
    public GameObject wall;

    void Update()
    {
        if (keyValue == 1)
        {
            Destroy(wall.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keyValue++;
            keyText.text = "Keys: " + keyValue;
            Update();
            Destroy(gameObject);
        }
    }
}