/***
 * Author: Andrew Nguyen
 * Created: 26 November 2022
 * Modified: 26 November 2022
 * Description: Manages the start menu of the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpCanvas : MonoBehaviour
{
    public string menuName;

    public void BackMenu()
    {
        SceneManager.LoadScene(menuName);
    }
}
