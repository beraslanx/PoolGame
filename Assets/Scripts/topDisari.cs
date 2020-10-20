using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDisari : MonoBehaviour
{
  
    private Vector3 lokasyon;
    public Rigidbody top;
    // Start is called before the first frame update
    void Start()
    {
        top = GetComponent<Rigidbody>();
        lokasyon = this.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        while (top.transform.position.y<lokasyon.y)
        {
            top.velocity = Vector3.zero;
            top.angularVelocity = Vector3.zero;
            
            top.drag = 25;
            top.transform.position = lokasyon;
            
        }
        top.drag=0.5f;
    }
}
