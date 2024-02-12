using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // for TextMeshPro text instead of just text

// Needs to countdown from a certain time = game duration
public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText; // private but can see in editor

    void Start()
    {
        // Once the game starts, setting current time to starting time
        currentTime = startingTime;
    }

    void Update()
    {
        // currentTime -= 1 does by each frame...bad
        currentTime -= 1 * Time.deltaTime; // decreases by 1 each second instead
        print (currentTime);
        countdownText.text = currentTime.ToString("0"); // displays countdown timer

        if (currentTime <= 0) // don't go below 0
        {
            currentTime = 0;
        }

        if (currentTime <= 3.5) // add urgency with color
        {
            countdownText.color = Color.red;
        }
    }
}
