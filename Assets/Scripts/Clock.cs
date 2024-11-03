using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject secondsHand;
    public GameObject minuteHand;
    public GameObject hourHand;

    int lastSecond;

    void Start()
    {
        lastSecond = DateTime.Now.Second;
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        int currentSecond = DateTime.Now.Second;

        if (currentSecond != lastSecond)
        {
            float secs = DateTime.Now.Second;
            float secsXRotation = (secs / 60f) * 360f;
            secondsHand.transform.rotation = Quaternion.Euler( secsXRotation, 0, 0);

            float mins = DateTime.Now.Minute;
            float minsXRotation = (mins / 60f) * 360f;
            minuteHand.transform.rotation = Quaternion.Euler( minsXRotation, 0, 0);

            float hrs = DateTime.Now.Hour % 12;
            float hrsXRotation = (hrs / 12f) * 360f + (mins / 60f) * 30f;
            hourHand.transform.rotation = Quaternion.Euler( hrsXRotation, 0, 0);

            lastSecond = currentSecond;
        }
    }
}
