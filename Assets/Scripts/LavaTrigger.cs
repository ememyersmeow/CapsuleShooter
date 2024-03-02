using System;
using UnityEngine;

public class LavaTrigger : MonoBehaviour
{
    public int damage = 50;
    private float lastTime;
    public float fireRate = 0.5f;
    public bool inLava = false;
    private HPplayer hpplayer;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inLava = true;
            hpplayer = collision.gameObject.GetComponent<HPplayer>();
        }
    }

    private void OnTriggerExit(Collider collision)
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
            hpplayer.currentHP -= damage;
        }
    }
}
