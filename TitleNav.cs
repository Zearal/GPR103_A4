using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleNav : MonoBehaviour
{
    
    public void Start()
    {
        AudioManager.instance.PlaySound("Title");
    }
    public void OnStartButton()
    {
        AudioManager.instance.PlaySound("Button");
        AudioManager.instance.StopAllAudio();
        SceneManager.LoadScene(1);
    }
    public void OnQuitButton()
    {
        AudioManager.instance.PlaySound("Button");
        Application.Quit();
        Debug.Log("We have quit");
    }
}
