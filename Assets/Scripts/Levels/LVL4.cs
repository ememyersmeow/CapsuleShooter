using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL4 : MonoBehaviour
{
    private int keyValue = 3;
    public TMP_Text keyText;
    public GameObject wall;


    void Update()
    {
        if (keyValue == 4)
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
