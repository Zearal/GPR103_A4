using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Ship : MonoBehaviour
{
    public int hp = 5;
    public float moveSpeed = 4.5f;
    public float laserSpeed = 25f;
    private bool mainGunCooldown = false;
    private GameObject target;
    private Rigidbody2D rb;
    public GameObject laserPrefab;
    public GameObject hitEffect;
    public Transform firePoint1;
    public Transform firePoint2;

    private Vector2 movement;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("PlayerShip");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "BlueLaser")
        {
            hp--;
            if (hp <= 0)
            {
                AudioManager.instance.PlaySound("Explosion");
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect);
                GameManager.instance.ScoreTracker(100);
                GameManager.instance.Spawn();
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "RedLaser")
        {
            hp -= 3;
            if (hp <= 0)
            {
                AudioManager.instance.PlaySound("Explosion");
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect);
                GameManager.instance.ScoreTracker(100);
                GameManager.instance.Spawn();
                Destroy(gameObject);
            }
        }
    }
    void Update()
    {
        Vector3 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle - 90f;
        direction.Normalize();
        movement = direction;
    }
    void FixedUpdate()
    {
        Vector3 dontCrash = target.transform.position - transform.position;

        if (dontCrash.x >= 3 || dontCrash.x <= -3 || dontCrash.y >= 3 || dontCrash.y <= -3)
        {
            MoveShip(movement);
        }
        
        ShootMain();
    }
    private void MoveShip(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
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
        yield return new WaitForSeconds(1.3f);
        mainGunCooldown = false;
    }
}
