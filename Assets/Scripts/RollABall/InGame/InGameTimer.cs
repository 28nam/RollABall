using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{
    public Text TimerText;
    private float timerTime = 20f;

    // Sphere destruction logic
    GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        // Sphere destruction
        sphere = GameObject.Find("Sphere");
        if (timerTime <= 0)
        {
            Destroy(sphere);
            Debug.Log("Sphere ‚ð”jŠü‚µ‚Ü‚µ‚½B");
        }

        // Update timer
        if (timerTime < 0)
        {
            TimerText.text = "0";

        }
        else
        {
            TimerText.text = $"{StringUtility.SecondsToTwoDecimalPlaces(timerTime -= Time.deltaTime)}";
        }
    }
}
