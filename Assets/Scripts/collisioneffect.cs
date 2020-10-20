using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioneffect : MonoBehaviour
{
    public static float hiz;
    public AudioSource hit;
    float startVolume;
     Rigidbody rb;
     void Start()
    {
       
        startVolume = hit.volume;
        
        rb = GetComponent<Rigidbody>();
       

    }

    void Update()
    {
        hiz = rb.velocity.magnitude;
        if (rb.velocity == Vector3.zero)
        {
            hit.volume = startVolume;


        }

    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Ball" || coll.collider.tag == "masa")


        {
            hit.volume /= 5 / rb.velocity.magnitude;
            hit.Play();
        }

    }


}
