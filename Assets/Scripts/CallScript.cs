using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CallScript : MonoBehaviour
{
    public Rigidbody beyaz;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        beyaz = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public float  Update()
    {
        speed = beyaz.velocity.magnitude;
        return speed;
    }
}
