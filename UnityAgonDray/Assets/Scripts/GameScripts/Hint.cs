/***
 * Author: Andrew Nguyen
 * Created: 1 December 2022
 * Modified: 1 December 2022
 * Description: Manages the start menu of the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject lights;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Look over at the blue.");
            lights.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        lights.SetActive(true);
    }
}
