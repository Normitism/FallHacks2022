using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Breth : MonoBehaviour
{
    float floattime = 30f;
    bool occurance = false;
    public Timer timer;
    // Update is called once per frame
    void Update()
    {
        if(timer.currenttime<30 )
        {
            float waittime = floattime - 3;
            if (timer.currenttime < waittime)
            {
                FindObjectOfType<AudioManager>().Play("Breathing1");
                floattime = timer.currenttime;
            }
        
        }
        if (timer.currenttime < 15 )
        {
            float waittime = floattime - 2.5f;
            if (timer.currenttime < waittime)
            {
                FindObjectOfType<AudioManager>().Play("Breathing1.3");
                floattime = timer.currenttime;
            }

        }
        if (timer.currenttime < 15 )
        {
            float waittime = floattime - 1f;
            if (timer.currenttime < waittime)
            {
                FindObjectOfType<AudioManager>().Play("Breathing1.5");
                floattime = timer.currenttime;
            }

        }
        if (timer.currenttime < 6)
        {
            float waittime = floattime;
            if (occurance == false )
            {
                FindObjectOfType<AudioManager>().Play("Breathing2");
                floattime = timer.currenttime;
                occurance = true;
            }

        }
    }
}
