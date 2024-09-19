using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 65 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down, 65 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.right * Time.deltaTime;
    }
}
