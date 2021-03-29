using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    bool timerActive = false;
    float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        System.TimeSpan time = System.TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "Time Elapsed: " + time.ToString(@"hh\:mm\:ss");

    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
        currentTime = 0;
    }
}
