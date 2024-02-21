using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 20f;
    public float fireRate = 10f;
    public float range = 200f;
    public ParticleSystem muzzleFlash;
    public AudioClip shotSFX;
    public AudioSource _audioSource;
    public Transform bulletSpawn;

    public Camera _cam;
    private float lastTimeFired = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        _audioSource.PlayOneShot(shotSFX);
        muzzleFlash.Play();

        RaycastHit hit;

        if(Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
            Debug.DrawRay(transform.position, transform.forward);
            Debug.Log("Nice shot!" + hit.collider);
            lastTimeFired = Time.time;

            if (hit.collider.tag == "Target")
            {
                Destroy(hit.collider.gameObject);
            }

            if ((Time.time - lastTimeFired) > 1f / fireRate)
            {
                lastTimeFired = Time.time;
            }
        }
    }
}
