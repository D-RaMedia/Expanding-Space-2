
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public GameObject Lose;
    public float startTime;
    public float endTime;
    public float losetime;

    void Start()
    {

    }

    void Update()
    {
        //float t = startTime - Time.time;
        float t = startTime -= Time.deltaTime;

        losetime -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 59.52999).ToString("00");

        timerText.text = "Time: " + minutes + "." + seconds;

        if (losetime <= 0)
        {
            bool isActive = Lose.activeSelf;

            Lose.SetActive(true);
        }
    }
}
