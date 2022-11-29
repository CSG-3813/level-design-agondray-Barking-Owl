/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 28 November 2022
 * Description: Manages the relics and health of the player, and decides gameover
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public int relics; //The relics the player collected so far
    static public int health; //How many hits the player takes before gameover
    static public bool won = false; //Did the player win. By default it is false.


    // Start is called before the first frame update
    void Start()
    {
        relics = 0;
        health = 1;
    }

    public static void LoseHealth()
    {
        health--; //Should also give the player a grace period before they can lose health again
    }


    // Update is called once per frame
    void Update()
    {
        GameOverCheck();
    }

    void GameOverCheck()
    {
        if (health <= 0)
        {
            GameOver();
        }
    }

    //If the player defeated the boss then they've won, otherwise they lost and take them to the loss screen
    public static void GameOver()
    {
        if (won == true)
        {
            SceneManager.LoadScene("End");
        }
        else
        {
            SceneManager.LoadScene("Loss");
        }
    }
}
