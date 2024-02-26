using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPTriggerLVL2 : MonoBehaviour
{
    public float t = 0;
    public float amp = 0.25f;
    public float freq = 2;
    public float offset = 0;
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        t = t + Time.deltaTime;
        offset = amp * Mathf.Sin(t * freq);
        transform.position = startPos + new Vector3(0, offset, 0);

        transform.Rotate(new Vector3(0, 0.5f, 0));
    }

    void PlayerHP()
    {
        HPplayerLVL2.HP += 150;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (HPplayer.HP <= 350)
            {
                PlayerHP();
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Your HP > 350");
            }
        }
    }
}

