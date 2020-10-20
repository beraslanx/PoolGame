using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scriptball : MonoBehaviour
{
    public static int sayi = 0;
    float playerx, playerz, ballx, ballz;
    float speed,bolen;
    public CallScript callScript;
    public GameObject cue;
    public float force=5f;
    private Vector3 dir;
    private Rigidbody Ball_00;

    public PowerBar powerbar;
    // Start is called before the first frame update
    void Start()
    {
        Ball_00 = GetComponent<Rigidbody>();
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            sayi = 0;
        }
        speed = callScript.Update();
        if (speed == 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                sayi++;


                playerx = cue.transform.position.x / 100;

                playerz = cue.transform.position.z / 100;
                ballx = Ball_00.transform.position.x / 100;
                ballz = Ball_00.transform.position.z / 100;



                playerx = ballx - playerx;
                playerz = ballz - playerz;
                float katsayi = PowerBar.currentPowerBarValue;
                dir = new Vector3((playerx), 0, (playerz));
                   Ball_00.AddForce(dir * force * 100 * katsayi/10);
                //if (playerx <= playerz)
                //{
                //    if (playerx<0)
                //    {
                //        bolen = -playerx;
                //    }

                //    playerx = playerx / bolen;
                //    playerz = playerz / bolen;
                //    dir = new Vector3((playerx), 0, (playerz));
                //    Ball_00.AddForce(dir * force * 100);

                //}
                //else if (playerz < playerx)
                //{
                //    if (playerz < 0)
                //    {
                //        bolen = -playerz;
                //    }

                //    playerx = playerx / bolen;
                //    playerz = playerz / bolen;
                //    dir = new Vector3((playerx), 0, (playerz));
                //    Ball_00.AddForce(dir * force * 100);

                //}



            }
        }
    }
}
