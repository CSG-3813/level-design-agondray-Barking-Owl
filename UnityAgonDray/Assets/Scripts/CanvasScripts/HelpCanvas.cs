/***
 * Author: Andrew Nguyen
 * Created: 26 November 2022
 * Modified: 30 November 2022
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

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
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
