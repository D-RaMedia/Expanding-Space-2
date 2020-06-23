using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timertester : MonoBehaviour
{ 
    public float testtimeleft;
     
     void Update()
     {
         testtimeleft -= Time.deltaTime;
         Debug.Log(testtimeleft);
     }
}
