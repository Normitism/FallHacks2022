using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class heartbeat : MonoBehaviour
{
    float floattime =  30f;
    public Timer timer;

    // Update is called once per frame
    void Update()
    {
        float waittime = (floattime - (floattime/25.0f))-0.33f;
        print(waittime);
        if (timer.currenttime < waittime)
        {
            FindObjectOfType<AudioManager>().Play("Heartbeat");
            floattime = timer.currenttime;
        }
    }
}
