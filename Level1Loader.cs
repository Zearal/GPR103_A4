using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Loader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(SpawnTimer());

        AudioManager.instance.PlaySound("Battle2");
        
        GameManager.instance.BeginGame();
    }
    IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(30f);
        GameManager.instance.Spawn();
        StartCoroutine(SpawnTimer());
    }
}
