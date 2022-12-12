/***
 * Author: Andrew Nguyen
 * Created: 27 November 2022
 * Modified: 27 November 2022
 * Description: Manages a non-moving enemy. These enemies may use a ranged attack.
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyStatic : MonoBehaviour
{
    public string TargetTag = "Player";
    public bool invincible = false; //Not for the enemy but the player

    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Invulnerable()
    {
        invincible = true;

        yield return new WaitForSeconds(1.0f);

        invincible = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            Debug.Log("Hit an enemy");
            if (invincible == false)
            {
                GameManager.LoseHealth();
            }
            StartCoroutine("Invulnerable");
        }
    }

}
