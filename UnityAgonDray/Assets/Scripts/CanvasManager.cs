/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 25 November 2022
 * Description: Manages the UI for the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text relicTextbox;
    public Text healthTextbox;
    public Text messageTextbox; //Tells you if you don't have enough relics

    public int hp;
    public int relics;

    // Start is called before the first frame update
    void Start()
    {
        SetStats();

        if (messageTextbox) { messageTextbox.text = ""; } //Only set this at the beginning

        SetUI();
    }

    // Update is called once per frame
    void Update()
    {
        SetUI();
    }

    void SetUI()
    {
        SetStats();

        if (relicTextbox) { relicTextbox.text = "Relics " + relics + " / 5"; }
        if (healthTextbox) { healthTextbox.text = "Can take " + hp + " more hits"; }
        NotEnough();
    }

    void SetStats()
    {
        hp = GameManager.health;
        relics = GameManager.relics;
    }
    public void NotEnough()
    {
        if (Door.flag == true)
        {
            messageTextbox.text = "Not enough relics!";
        }
        else
        {
            messageTextbox.text = "";
        }
    }
}
