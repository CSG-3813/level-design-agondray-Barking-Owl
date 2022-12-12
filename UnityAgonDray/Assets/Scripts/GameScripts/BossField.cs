using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossField : MonoBehaviour
{
    public GameObject Stone;
    public Animator StoneAnimator;
    public AudioSource StoneSound;

    // Start is called before the first frame update
    void Start()
    {
        StoneAnimator = Stone.GetComponent<Animator>();
        StoneSound = Stone.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StoneAnimator.SetTrigger("Block");
            StoneSound.Play();
            Destroy(gameObject);
        }
    }
}
