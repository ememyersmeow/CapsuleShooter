using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL5 : MonoBehaviour
{
    private int keyValue = 4;
    public TMP_Text keyText;
    public GameObject wall;
    public GameObject wall2;

    public GameObject[] enemy4 = new GameObject[0];

    void Update()
    {
        if (keyValue == 5)
        {
            Destroy(wall.gameObject);
            Destroy(wall2);
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

