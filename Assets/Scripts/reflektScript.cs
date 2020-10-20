using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflektScript : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 lastVelocity;
   
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;

    }
    private void OnCollisionEnter(Collision coll)
    {
        


        float speed = (lastVelocity.magnitude) ;
        Vector3 direciton = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
        if (scriptball.sayi == 1)
        {
            //if (coll.collider.tag != "Ball")
            //{
            //    rb.velocity = direciton * Mathf.Max(speed, 0f);

            //}

            // if (coll.collider.tag != "masa") return;


            if (coll.collider.tag == "Ball")
            {

                rb.velocity = direciton * Mathf.Max(speed / 10, 0f);
            }
        }

        if (coll.collider.tag != "masa") return;

        rb.velocity = direciton * Mathf.Max(speed, 0f);
        
        
            
        
    }
}
