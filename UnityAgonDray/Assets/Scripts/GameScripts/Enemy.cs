/***
 * Author: Andrew Nguyen
 * Created: 27 November 2022
 * Modified: 27 November 2022
 * Description: Manages enemies
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Enemy : MonoBehaviour
{
    public string TargetTag = "Player";
    public bool invincible = false; //Not for the enemy but the player

    public float SpeedThreshold = 0.1f;
    public string AnimParam = "Move";

    public Transform dest; //Where the enemy is headed

    private NavMeshAgent thisAgent;
    private Animator thisAnimator;

    private void Awake()
    {
        thisAgent = GetComponent<NavMeshAgent>();
        thisAnimator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thisAgent.SetDestination(dest.position);
        thisAnimator.SetBool(AnimParam, thisAgent.velocity.magnitude > SpeedThreshold);
    }

    IEnumerator Invulnerable()
    {
        invincible = true;

        yield return new WaitForSeconds(1.0f);

        invincible = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TargetTag))
        {
            Debug.Log("Hit an enemy");
            if (invincible == false)
            {
                GameManager.LoseHealth();
            }
            StartCoroutine("Invulnerable");
        }
    }

    /*private void OnTriggerEnter(Collider other)
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
    */
}
