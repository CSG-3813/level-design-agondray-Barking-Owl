/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 28 November 2022
 * Description: Manages relic
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour
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
        }
    }

}
