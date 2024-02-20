using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject trigger;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            SceneManager.LoadScene(2);
        }
    }
}
