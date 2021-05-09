using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject timeHUD, scoreHUD, gameOverHUD;
    public GameObject enemy;
    public Text timer, scorer, gameOverScore;
    public bool gamePlaying = false;
    public float score;
    public float totalScore, startTime, elapsedTime;
    TimeSpan timePlaying;
    public Slider slider;
    public List<Vector3> spawns = new List<Vector3>();
    public int spawnLoc;
    private Vector3 spawn;

    public int colourOption = 0;

    private void Awake()
    {
        instance = this;
    }

    public void BeginGame()
    {
        gamePlaying = true;
        startTime = Time.time;
    }

    public void ScoreTracker(float scoreFloat)
    {
        score += scoreFloat;
        scorer.text = "Score: " + score.ToString("");
    }

    public void Spawn()
    {
        spawnLoc++;
        if(spawnLoc >= spawns.Count)
        {
            spawnLoc = 0;
        }
        spawns[spawnLoc] = spawn;
        Instantiate(enemy, spawn, Quaternion.identity);
    }
    
    public void GameOver()
    {
        gamePlaying = false;
        gameOverHUD.SetActive(true);
        scoreHUD.SetActive(false);
        timeHUD.SetActive(false);
        string timePlayingString = "Time: " + timePlaying.ToString("mm':'ss");
        gameOverScore.text = "Score: " + score.ToString("") + " - " + timePlayingString;
    }

    private void Update()
    {
        if (gamePlaying == true)
        {
            elapsedTime = Time.time - startTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);

            string timePlayingString = "Time: " + timePlaying.ToString("mm':'ss");
            timer.text = timePlayingString;
        }
    }
}
