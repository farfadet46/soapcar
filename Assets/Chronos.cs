using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronos : MonoBehaviour
{
    public float time = 0f;
    public float TimerInterval = 5f;
    float tick;
    //TMPro.TextMeshProUGUI chronos;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    private void Awake()
    {
        time = (int)Time.time;
        tick = TimerInterval;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("{0:0}:{1:00}", Math.Floor(time/60),time%60); 
            //ime.ToString();

        time = (int)Time.time;
        /*if(time==tick)
        {
            tick = time + TimerInterval;
            TimerExecute();
        }
        */
    }
    /*
    void TimerExecute()
    {
        Debug.Log ("Timer");
    }
    */
}
