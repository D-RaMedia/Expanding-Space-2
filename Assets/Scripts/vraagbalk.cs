using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vraagbalk : MonoBehaviour
{
    [SerializeField]private DropOff dropOff;
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject energy;
    [SerializeField] private GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dropOff.benoodigd == "Water"){
            water.SetActive(true);
        }else if(dropOff.benoodigd == "Energy"){
            energy.SetActive(true);
        }
        else if(dropOff.benoodigd == "Food"){
            food.SetActive(true);
        }
    }
}
