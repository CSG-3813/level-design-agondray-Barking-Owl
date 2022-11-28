/***
 * Author: Andrew Nguyen
 * Created: 27 November 2022
 * Modified: 27 November 2022
 * Description: Manages the midpoint relic
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialRelic : MonoBehaviour
{
    public string TargetTag = "Player";
    public GameObject Enemy;

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
            Destroy(Enemy);
            Debug.Log("Relic found! Relics found so far: " + GameManager.relics);
            Destroy(gameObject);
        }
    }

}
