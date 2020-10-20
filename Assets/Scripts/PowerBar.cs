using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    float a;
    public GameObject powerbargo;
    public Image PowerBarMask;
    public float barChangeSpeed = 1;
    float maxPowerBarValue = 25;
    public static float currentPowerBarValue;
    bool powerIsIncreasing;
    bool PowerBarON;
    // Start is called before the first frame update
    void Start()
    {
        currentPowerBarValue = maxPowerBarValue;
        powerIsIncreasing = false;
        powerbargo.SetActive(false);

    }
    IEnumerator UpdatePowerBar()
    {
        while (PowerBarON)
        {
            if (!powerIsIncreasing)
            {
                currentPowerBarValue -= barChangeSpeed;
                if (currentPowerBarValue<=0)
                {
                    powerIsIncreasing = true;
                }
            }
            if (powerIsIncreasing)
            {
                currentPowerBarValue += barChangeSpeed;
                if (currentPowerBarValue >= maxPowerBarValue)
                {
                    powerIsIncreasing = false;
                }
            }
           
            float fill = currentPowerBarValue / maxPowerBarValue;
            PowerBarMask.fillAmount = fill;
            yield return new WaitForSeconds(0.02f);
           

        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            if (Input.GetMouseButtonDown(0))
            {

                PowerBarON = true;
                powerbargo.SetActive(true);
                StartCoroutine(UpdatePowerBar());
            }
            if (Input.GetMouseButtonUp(0))
            {
                PowerBarON = false;
                powerbargo.SetActive(false);


            }

        }

    }
    

}
