using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    private Vector3 firstPosition;

    public GameObject istakaUcu, beyazTop, geri;
    private Vector3 startPos;
    private Vector3 endPos, sonPos;
    //public float distance = 5f;
    public float lerpTime, lerpTime2 = 2;
    private float currentLerpTime, currentLerpTime2 = 0;
    private bool keyHit, keyHit2 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = istakaUcu.transform.position;

            endPos = geri.transform.position;
           
            keyHit = true;
        }
        if (keyHit == true)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }

            float Perc = currentLerpTime / lerpTime;
            istakaUcu.transform.position = Vector3.Lerp(startPos, endPos, Perc);
            keyHit = false;

        }
        if (Input.GetMouseButtonUp(0))
        {
            //sonPos = adam.transform.position;
            keyHit2 = true;
        }
        if (keyHit2 == true)
        {
            currentLerpTime2 += Time.deltaTime;
            if (currentLerpTime2 >= lerpTime2)
            {
                currentLerpTime2 = lerpTime2;
            }

            float Perc2 = currentLerpTime2 / lerpTime2;
            istakaUcu.transform.position = Vector3.Lerp(endPos, startPos, Perc2);
            keyHit2 = false;
        }


    }
}
