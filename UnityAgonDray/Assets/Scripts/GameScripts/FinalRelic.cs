/***
 * Author: Andrew Nguyen
 * Created: 27 November 2022
 * Modified: 27 November 2022
 * Description: Manages the final relic to win the game
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRelic : MonoBehaviour
{
    public string TargetTag = "Player";

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
        if (other.CompareTag(TargetTag))
        {
            GameManager.relics++;
            GameManager.health++;
            Debug.Log("Relic found! Relics found so far: " + GameManager.relics);
            Destroy(gameObject);
            GameManager.won = true;
            GameManager.GameOver();
        }
    }

}
