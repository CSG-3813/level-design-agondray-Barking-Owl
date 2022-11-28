/***
 * Author: Andrew Nguyen
 * Created: 28 November 2022
 * Modified: 28 November 2022
 * Description: Manages the projectile itself (may also function as a mine)
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool invincible = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroySelf", 5.0f); //A projectile that lasts 5 seconds
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
        Debug.Log("Hit an enemy's projectile");
        if (other.CompareTag("Player"))
        {
            if (invincible == false)
            {
                GameManager.LoseHealth();
                DestroySelf();
            }
        }
        StartCoroutine("Invulnerable");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
