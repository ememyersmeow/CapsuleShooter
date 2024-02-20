using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL1 : MonoBehaviour
{
    private int keyValue = 0;
    public TMP_Text keyText;
    public GameObject wall;
    public GameObject wall2;

    public GameObject[] enemy1 = new GameObject[7];

    void Update()
    {
        if (keyValue == 1)
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
            keyText.text = "Keys: " + keyValue;
        }
    }
}