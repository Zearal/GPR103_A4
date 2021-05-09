using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD_Buttons : MonoBehaviour
{
    public void RetryButton()
    {
        AudioManager.instance.PlaySound("Button");
        SceneManager.LoadScene(2);
    }
    public void QuitButton()
    {
        AudioManager.instance.PlaySound("Button");
        Application.Quit();
        Debug.Log("We have quit");
    }
}
