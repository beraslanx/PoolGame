using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffect : MonoBehaviour
{
    public AudioSource hit2;



     void Update()
    {
        if (collisioneffect.hiz == 0)
        {
            hit2.volume = 0.247f;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Ball" || col.collider.tag == "masa")

        {

            hit2.volume = hit2.volume / 2;
            hit2.Play();
        }
    }

}
