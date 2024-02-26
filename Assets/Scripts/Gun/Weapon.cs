using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Xml;


public class Weapon : MonoBehaviour
{
    public float damage = 20f;
    public float range = 200f;
    public ParticleSystem muzzleFlash;
    public AudioClip shotSFX;
    public AudioSource _audioSource;
    public Transform bulletSpawn;

    public Image image;

    [SerializeField] private int currentAmmo;
    [SerializeField] private int maxAmmoInMag;
    public int totalAmmo;

    [SerializeField] private float fireRate = 0.15f;

    private float lastshot;

    public TMP_Text ammoText;

    public Camera _cam;
    private float lastTimeFired = 0f;

    public void Start()
    {
        UpdateText();
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    void Shoot()
    {
        if ((Time.time - lastshot) < fireRate || currentAmmo <= 0)
            return;

        lastshot = Time.time;
        currentAmmo--;
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
                hit.collider.GetComponent<EnemyHealth>().health -= damage;
                image.enabled = true;
                StartCoroutine(Hitmarker()); //start timer

            }

            if ((Time.time - lastTimeFired) > 1f / fireRate)
            {
                lastTimeFired = Time.time;
            }
        }

        

        UpdateText();
    }

    public void Reload()
    {
        if (currentAmmo >= maxAmmoInMag || totalAmmo <= 0)
            return;
        int needAmmo = maxAmmoInMag - currentAmmo;
        int haveAmmo = Mathf.Min(needAmmo, totalAmmo);
        if (haveAmmo == 0)
            return;
        totalAmmo -= haveAmmo;
        currentAmmo += haveAmmo;
        UpdateText();
    }

    public IEnumerator Hitmarker() // Timer
    {
        yield return new WaitForSeconds(0.07f); // after 0.07 sec delete
        image.enabled = false;
    }

    public void UpdateText()
    {
        ammoText.text = currentAmmo.ToString() + "/" + totalAmmo.ToString();
    }
}
