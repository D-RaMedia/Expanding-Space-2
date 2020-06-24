using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public int MoneyGoal;

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


        if (moneyAmount >= MoneyGoal)
        {
            Panel.SetActive(true);
        }
        if (Panel.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Tutorial_Level_2");
            }
        }


        if (moneyAmount >= MoneyGoal)
        {
            Panel1.SetActive(true);
        }
        if (Panel1.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Tutorial_Level_3");
            }
        }


        if (moneyAmount >= MoneyGoal)
        {
            Panel2.SetActive(true);
        }
        if (Panel2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }


        if (moneyAmount >= MoneyGoal)
        {
            Panel3.SetActive(true);
        }
        if (Panel3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}
