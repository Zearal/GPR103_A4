using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyButtons : MonoBehaviour
{
    public void Start()
    {
        AudioManager.instance.PlaySound("Lobby");
    }
    public void BackButton()
    {
        AudioManager.instance.PlaySound("Button");
        AudioManager.instance.StopAllAudio();
        SceneManager.LoadScene(0);
    }
    public void Level1()
    {
        AudioManager.instance.PlaySound("Button");
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        AudioManager.instance.PlaySound("Button");
        Debug.Log("Loading level 2");
    }
    public void Level3()
    {
        AudioManager.instance.PlaySound("Button");
        Debug.Log("Loading level 3");
    }

}
