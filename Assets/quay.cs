using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quay : MonoBehaviour
{
    GameObject gold;
    
    // Start is called before the first frame update
    void Start()
    {
        gold = GameObject.FindGameObjectWithTag("gold");
    }

    // Update is called once per frame
    void Update()
    {

        
            
            gold.transform.Rotate(Vector3.left * 1000f);

        
    }

}
