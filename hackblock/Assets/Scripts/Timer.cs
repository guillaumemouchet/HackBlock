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
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            isFinished = true;
            SelectEvent();
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
        int test  = Random.Range(1, 2);

        switch(test)
        {
            case 1: // MAIL
                SpriteRenderer sprite  = mail.GetComponent<SpriteRenderer>();
                sprite.sprite = spriteMailNotif;
                ApplicationMail.hasEvent = true;
                break;
            case 2: // WIFI
                TextMeshProUGUI text = wifi.GetComponent<TextMeshProUGUI>();
                text.text = "No wifi";
                ApplicationSettings.hasEvent = true;
                break;



        }
        ResetTimer();


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
    [SerializeField] private Sprite spriteMailNotif;
    [SerializeField] private Sprite spriteMail;
    //[SerializeField] private GameObject settings;
    [SerializeField] private GameObject wifi;


}
