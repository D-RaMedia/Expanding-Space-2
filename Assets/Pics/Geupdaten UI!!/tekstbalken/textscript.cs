using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textscript : MonoBehaviour
{
    public GameObject currenttext;
    public GameObject nexttext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(currenttext.activeSelf == true)
            {
            currenttext.SetActive(false);
            nexttext.SetActive(true);
            }
        }
    }
}
