using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScript : MonoBehaviour
{
    
    public float testtimeleft;
    public GameObject stars3;
    
    public GameObject stars2;
    
    public GameObject stars1;
    // Start is called before the first frame update
    void Start()
    {
        stars3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
         testtimeleft -= Time.deltaTime;
         Debug.Log(testtimeleft);
         
        if(testtimeleft <= 20)
        {
            stars3.SetActive(false);
            stars2.SetActive(true);
        }

        if(testtimeleft <= 10)
        {
            stars2.SetActive(false);
            stars1.SetActive(true);
        }
    }
}
