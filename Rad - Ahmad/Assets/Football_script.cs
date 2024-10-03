using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football_script : MonoBehaviour
{
    Rigidbody rb;
    internal void kick(Vector3 position)
    {
        print("I've been kicked");
        rb.AddExplosionForce(500, position + new Vector3(0, -1, 0), -1);



    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
