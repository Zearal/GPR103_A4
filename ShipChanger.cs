using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ShipChanger : MonoBehaviour
{
    public SpriteRenderer shipColour;
    public List<Sprite> colourOptions = new List<Sprite>();
    public int currentOption = 0;


    public void NextOption()
    {
        currentOption++;
        if(currentOption >= colourOptions.Count)
        {
            currentOption = 0;//This resets if we go past the list size
        }
        shipColour.sprite = colourOptions[currentOption];
    }
    public void PreviousOtion()
    {

        if (currentOption == 0)
        {
            currentOption = 4;
        }
        else
        {
            currentOption--;
        }
        shipColour.sprite = colourOptions[currentOption];
    }
    public void ConfirmButton()
    {
        Player.currentOption = currentOption;
        Debug.Log("Colour Saved");
    }
}
