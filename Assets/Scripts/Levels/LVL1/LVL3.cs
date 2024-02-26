using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL3 : MonoBehaviour
{
    private int keyValue = 2;
    public TMP_Text keyText;
    public GameObject wall;

    public GameObject[] enemy3 = new GameObject[0];

    void Update()
    {
        if (keyValue == 3)
        {
            Destroy(wall.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keyValue += 1;
            Update();
            keyText.text = "Keys: " + keyValue;
        }
    }
}