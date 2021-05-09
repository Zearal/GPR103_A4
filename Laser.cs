using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject hitEffect;
    public int timer = 3;
    

    private void Start()
    {
        
        StartCoroutine(DestroyLaser());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }

    IEnumerator DestroyLaser()
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }
}
