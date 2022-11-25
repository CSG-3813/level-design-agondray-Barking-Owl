/***
 * Author: Andrew Nguyen
 * Created: 25 November 2022
 * Modified: 25 November 2022
 * Description: Manages the false wall
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseWall : MonoBehaviour
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
            gameObject.SetActive(false);
        }
    }
}
