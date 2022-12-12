/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 30 November 2022
 * Description: Manages the start menu of the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCanvas : MonoBehaviour
{
    public string levelName;
    public string helpScreen;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameStart()
    {
        SceneManager.LoadScene(levelName);
    }

    public void GameHelp()
    {
        SceneManager.LoadScene(helpScreen);
    }
}
