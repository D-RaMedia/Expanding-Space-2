using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : TimerController
{
    public GameObject Panel;
    public GameObject Lose;
    public Text moneyText;
    public float moneyAmount;
    public float moneyIncreasedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = 0f;
        moneyIncreasedPerSecond = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "@   " + (int)moneyAmount;
        moneyAmount += moneyIncreasedPerSecond * Time.deltaTime;

        if (moneyAmount == 1000)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(true);
        }

        if(moneyAmount <= 1000)
        {
            if(startTime == 0)
            {
                bool isActive = Lose.activeSelf;

                Lose.SetActive(true);
            }
        }
    }
}
