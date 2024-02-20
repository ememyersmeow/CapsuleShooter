using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject objectToSwitch; 
    public GameObject otherObject;
    public Transform player;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == otherObject)
                {
                    objectToSwitch.SetActive(false);
                }
                else
                {
                    objectToSwitch.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            objectToSwitch.SetActive(true);
            Destroy(gameObject);
        }
    }

}