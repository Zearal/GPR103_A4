using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapons : MonoBehaviour
{
    PlayerControls controls;
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public GameObject laserPrefab;
    public GameObject largeLaserPrefab;
    public float laserSpeed = 25f;
    public float largeLaserSpeed = 20f;
    bool mainGunCooldown = false;
    bool altGunCooldown = false;

    void Awake()
    {
        controls = new PlayerControls();
        controls.InGame.MainWeapon.performed += ctx => ShootMain();
        controls.InGame.AltWeapon.performed += ctx => ShootAlt();
    }
    private void Start()
    {
        
    }
    void ShootMain()
    {
        if (mainGunCooldown == false)
        {
            AudioManager.instance.PlaySound("Laser");
            GameObject laser1 = Instantiate(laserPrefab, firePoint1.position, firePoint1.rotation);
            GameObject laser2 = Instantiate(laserPrefab, firePoint2.position, firePoint2.rotation);
            Rigidbody2D rb1 = laser1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = laser2.GetComponent<Rigidbody2D>();
            rb1.AddForce(firePoint1.up * laserSpeed, ForceMode2D.Impulse);
            rb2.AddForce(firePoint2.up * laserSpeed, ForceMode2D.Impulse);
            mainGunCooldown = true;
            StartCoroutine(CooldownMain());
        }
    }
    IEnumerator CooldownMain()
    {
        mainGunCooldown = true;
        yield return new WaitForSeconds(.3f);
        mainGunCooldown = false;
    }
    void ShootAlt()
    {
        if (altGunCooldown == false)
        {
            AudioManager.instance.PlaySound("AltLaser");
            GameObject largeLaser1 = Instantiate(largeLaserPrefab, firePoint3.position, firePoint3.rotation);
            GameObject largeLaser2 = Instantiate(largeLaserPrefab, firePoint4.position, firePoint4.rotation);
            Rigidbody2D rb1 = largeLaser1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = largeLaser2.GetComponent<Rigidbody2D>();
            rb1.AddForce(firePoint3.up * largeLaserSpeed, ForceMode2D.Impulse);
            rb2.AddForce(firePoint4.up * largeLaserSpeed, ForceMode2D.Impulse);
            altGunCooldown = true;
            StartCoroutine(CooldownAlt());
        }
    }
    IEnumerator CooldownAlt()
    {
        altGunCooldown = true;
        yield return new WaitForSeconds(1f);
        altGunCooldown = false;
    }
    private void OnEnable()
    {
        controls.InGame.Enable();
    }
    private void OnDisable()
    {
        controls.InGame.Disable();
    }
}
