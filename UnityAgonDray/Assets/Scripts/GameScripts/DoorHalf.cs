/***
 * Author: Andrew Nguyen
 * Created: 12 December 2022
 * Modified: 12 December 2022
 * Description: Manages door closing sound
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHalf : MonoBehaviour
{

    public AudioSource audioSrc;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponentInParent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    void PlaySound()
    {
        anim.SetTrigger("Close");
        audioSrc.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
