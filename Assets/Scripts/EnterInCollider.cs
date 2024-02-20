using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterInCollider : MonoBehaviour
{
    public Transform objectToTransform;
    public GameObject objectToTransform2;
    public Transform player;

    public void Start()
    {
        objectToTransform2.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            Destroy(objectToTransform.gameObject);
            objectToTransform2.SetActive(true);
        }    
    }
}
