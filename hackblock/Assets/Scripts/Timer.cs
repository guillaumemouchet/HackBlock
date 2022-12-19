/*
 * Title : Timer 
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */

using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Timer : MonoBehaviour
{
    public void Start()
    {
        ResetTimer();
    }

    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/
    private void Update()
    {
        if (ApplicationMail.hasEvent)
            mailNotif.SetActive(true);
        if (ApplicationSearch.hasEvent)
            searchNotif.SetActive(true);
        if (ApplicationSettings.hasEvent)
            settingNotif.SetActive(true);
        if (ApplicationSocialNetwork.hasEvent)
            socialNotif.SetActive(true);
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;

            if (!isFinished)
                SelectEvent();
            isFinished = true;
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Destroying timer");
    }

    private void SelectEvent()
    {
        print("END TIMER");
        int test  = Random.Range(1, 10);

        switch(test)
        {
            case 1: // MAIL
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                ApplicationMail.hasEvent = true;
                break;
            case 7: // SEARCH ENGINE
                ApplicationSearch.hasEvent = true;
                break;
            case 8:
                TextMeshProUGUI text = wifi.GetComponent<TextMeshProUGUI>();
                text.text = "No wifi";
                ApplicationSettings.hasEvent = true;
                break;
            case 9: //  SOCIAL NETWORK
                ApplicationSocialNetwork.hasEvent = true;
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
