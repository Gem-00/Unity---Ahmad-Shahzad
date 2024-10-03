using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Is Running", false);
        if (Input.GetKey(KeyCode.W))

        {
             transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("Is Running", true);

            rb = GetComponent<Rigidbody>();
            if (rb != null)
                print("Found Rigid Body");
            else
                print("Could not find Rigid Body");

        }
       
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down, 75 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 75 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.H))
            transform.Rotate(Vector3.up, 360 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddExplosionForce(250,
                transform.position + new Vector3(0, 0, 0), 0);




    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        collision.gameObject.transform.position += Vector3.forward;
        Football_script myFootball = collision.gameObject.GetComponent<Football_script>();
        if (myFootball != null)
        {
            myFootball.kick(transform.position);
        }

    }
}
