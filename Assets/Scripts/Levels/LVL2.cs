using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL2 : MonoBehaviour
{
    private int keyValue = 1;
    public TMP_Text keyText;
    public GameObject wall;

    public GameObject[] enemy2 = new GameObject[7];

    void Update()
    {
        if (keyValue == 2)
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