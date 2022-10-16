using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Timer : MonoBehaviour
{
    public float currenttime = 0f;
    public float starttime = 30f;
    [SerializeField]Text countdownText;
    void Start()
    {   
        currenttime = starttime;
    }
    void Update()
    {
        currenttime -= 1 * Time.deltaTime;
        countdownText.text=currenttime.ToString();
    }
}
