/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 12 December 2022
 * Description: Manages door behavior
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoor : MonoBehaviour
{
    public string TargetTag = "Player";
    public int relicsNeeded; //Amount of relics needed to open this door, by default 0
    public static bool flag;

    public AudioSource audioSrc;

    Animator[] anim;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        anim = GetComponentsInChildren<Animator>(); //Two doors so get both animators
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
                Debug.Log("Doors opening");
                audioSrc.Play();
                anim[0].SetTrigger("Open");
                anim[1].SetTrigger("Open");
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
            anim[0].SetTrigger("Close");
            anim[1].SetTrigger("Close");
        }

        flag = false;
    }


}
