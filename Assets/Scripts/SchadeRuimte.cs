﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchadeRuimte : MonoBehaviour
{
    [SerializeField]public bool isRepaired = false;
    [SerializeField]private SchadeActivator activator;
    [SerializeField]private GameObject Schadebalk;
    public GameObject blockade1;
    public GameObject blockade2;
    public GameObject blockade3;
    public bool inArea;
    public bool ReadyToFix = false;

    public bool isRepairing = false;

    public AudioSource Repair;
    
    private void OnTriggerEnter(Collider other) {
        inArea = true;

    }

    void OnTriggerExit(Collider other)
    {
        inArea = false;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Schadebalk = this.gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {   
        if(inArea && ReadyToFix){
            if(Input.GetKeyDown(KeyCode.R)){
                isRepaired = true;
            }
        }
        if(inArea && !isRepairing){
            if(Input.GetKeyDown(KeyCode.R)){
                isRepairing = true;
                Schadebalk.SetActive(true);
                Repair.Play();
            }
        } 

        if(isRepaired == true)
        {
            blockade1.SetActive(false);
            blockade2.SetActive(false);
            blockade3.SetActive(false);
        }
        
        if(isRepaired){
            activator.Countdown = Random.Range(10.0f,30.0f);
            activator.ActivateGenerators();
            isRepaired = false;
            Schadebalk.SetActive(false);
            activator.isActive = false;
            this.gameObject.SetActive(false);
        }

        if(ReadyToFix == true)
        {
            Repair.Stop();
        }
    }
}
