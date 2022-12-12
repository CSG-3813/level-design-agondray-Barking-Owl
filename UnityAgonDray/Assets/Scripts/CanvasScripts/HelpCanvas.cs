/***
 * Author: Andrew Nguyen
 * Created: 26 November 2022
 * Modified: 12 December 2022
 * Description: Manages the help menu of the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpCanvas : MonoBehaviour
{
    public string menuName;
    public string otherMenuName;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(menuName);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(otherMenuName);
    }
}
