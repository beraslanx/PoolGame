using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerascript : MonoBehaviour
{
    public Camera kamera;
    float ilkdeger;
    float minFov = 15f;
    float maxFov  = 90f;
    float sensitivity= 10f;
    // Start is cal  sensitivity led before the first frame update
    void Start()
    {
        ilkdeger= kamera.fieldOfView;

    }

    // Update is called once per frame
  
 
    void Update()
    {
        float fov  = kamera.fieldOfView;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        kamera.fieldOfView = fov;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kamera.fieldOfView =60;
        }
    }
}
