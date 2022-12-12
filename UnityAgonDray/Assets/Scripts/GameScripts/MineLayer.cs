/***
 * Author: Andrew Nguyen
 * Created: 28 November 2022
 * Modified: 28 November 2022
 * Description: Lays mines 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineLayer : MonoBehaviour
{
    public GameObject minePrefab;

    public float reloadTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        LayMine();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LayMine()
    {
        Instantiate(minePrefab, transform.position, transform.rotation);

        Invoke("LayMine", reloadTime); //Invoke repeating
    }
}
