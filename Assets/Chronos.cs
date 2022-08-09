using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronos : MonoBehaviour
{
    public float time = 0f;
    public float TimerInterval = 5f;
    float tick;

    void Start()
    {
        time = 0f;
    }

    private void Awake()
    {
        time = (int)Time.time;
        tick = TimerInterval;
    }

    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("{0:0}:{1:00}", Math.Floor(time / 60), time % 60);
        time = (int)Time.time;
    }
}
