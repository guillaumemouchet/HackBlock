/*
 * Title : Timer 
 * Authors : Titus Abele, Benjamin Mouchet, Guillaume Mouchet, Dorian Tan
 * Date : 29.08.2022
 * Source : 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Timer : MonoBehaviour
{
    public void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        if(ApplicationMail.hasEvent)
            mailNotif.SetActive(true);
        if (ApplicationSearch.hasEvent)
            searchNotif.SetActive(true);
        if (ApplicationSettings.hasEvent)
            settingNotif.SetActive(true);
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            
            if(!isFinished)
                SelectEvent();
            isFinished = true;
        }
    }


    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/


    private void OnDestroy()
    {
        Debug.Log("Destroying timer");
    }

    private void SelectEvent()
    {
        print("END TIMER");
        int test  = Random.Range(1, 3);

        switch(test)
        {
            case 1: // MAIL
                
                ApplicationMail.hasEvent = true;
                break;
            case 2: // SEARCH ENGINE
                ApplicationSearch.hasEvent = true;
                break;
            case 3: // WIFI
                TextMeshProUGUI text = wifi.GetComponent<TextMeshProUGUI>();
                text.text = "No wifi"; // TODO : Block other applications if wifi is down
                ApplicationSettings.hasEvent = true;
                break;
            case 4: //  SOCIAL NETWORK
                // TODO
                break;

        }
        //No reseting the timer to not have too keep the events stored, have one event at a time
    }

    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/


    public bool IsFinished()
    {
        return isFinished;
    }

    public void ResetTimer()
    {
        timeValue = TIMER_SECONDS;
        isFinished = false;
    }

    /***************************************************************\
     *                      Attributes private                     *
    \***************************************************************/

    private const float TIMER_SECONDS = 5f;
    public float timeValue;
    private bool isFinished = false;
    [SerializeField] private GameObject mail;
    [SerializeField] private GameObject mailNotif;

    [SerializeField] private GameObject search;
    [SerializeField] private GameObject searchNotif;


    [SerializeField] private GameObject wifi;
    [SerializeField] private GameObject settingNotif;

    [SerializeField] private GameObject socialNotif;



}
