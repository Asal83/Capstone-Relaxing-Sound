using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currenttime = 0f;
    float starttingtime = 30f;

    [SerializeField] Text CountdownText;
    void Start()
    {
        currenttime = starttingtime;
    }


    void update()
    {
        currenttime -= 1 * Time.deltaTime;
        CountdownText.text = currenttime.ToString("0");
        if (currenttime <= 0)
        {
            currenttime = 0;
        }
            
    }
}
     
  
   

