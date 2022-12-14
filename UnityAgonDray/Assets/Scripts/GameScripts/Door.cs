/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 25 November 2022
 * Description: Manages door behavior
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string TargetTag = "Player";
    public int relicsNeeded; //Amount of relics needed to open this door, by default 0
    public static bool flag; 

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TargetTag))
        {
            if (GameManager.relics >= relicsNeeded)
            {
                anim.SetTrigger("Open");
            }
            else
            {
                Debug.Log("Not enough relics!"); //Should also pop up a message on UI
                flag = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag(TargetTag))
        {
            anim.SetTrigger("Close");
        }

        flag = false;
    }


}
