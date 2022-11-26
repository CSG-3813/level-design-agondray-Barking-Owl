/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 25 November 2022
 * Description: Manages the relics and health of the player, and decides gameover
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public int relics; //The relics the player collected so far
    static public int health; //How many hits the player takes before gameover

    // Start is called before the first frame update
    void Start()
    {
        relics = 0;
        health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //If the player defeated the boss then they've won, otherwise they lost and take them to the loss screen
    void GameOver()
    {

    }
}
