using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrigger : MonoBehaviour
{
    public int damage = 50;
    private float lastTime;
    public float fireRate = 0.5f;
    public bool inLava = false;
    private HPplayerLVL2 hpplayer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inLava = true;
            hpplayer = collision.gameObject.GetComponent<HPplayerLVL2>();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inLava = false;
        }
    }

    public void Update()
    {
        if ((Time.time - lastTime) > fireRate && inLava)
        {
            lastTime = Time.time;
            hpplayer.HP -= damage;
        }
    }
}
