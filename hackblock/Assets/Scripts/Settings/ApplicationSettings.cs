/*
 * Title : ApplicationSettings 
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */
using TMPro;
using UnityEngine;


public class ApplicationSettings : MonoBehaviour
{


    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/
    private void OnEnable()
    {
        mainPanel.SetActive(true);
        wifiPanel.SetActive(false);
        proposPanel.SetActive(false);
        if (hasEvent)
        {
            notif.SetActive(true);
            wifiTxt.GetComponent<TextMeshProUGUI>().text = "Choose a new wifi";
        }

    }
    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/

    public void wifiClick()
    {
        mainPanel.SetActive(false);
        wifiPanel.SetActive(true);
    }

    public void connexionWifiClick()
    {
        wifiTxt.GetComponent<TextMeshProUGUI>().text = "Connected to the wifi";
        notif.SetActive(false);
        hasEvent = false;
    }

    public void proposClick()
    {
        mainPanel.SetActive(false);
        proposPanel.SetActive(true);
    }

    /***************************************************************\
    *                      Attributes private                     *
    \***************************************************************/
    [SerializeField] private GameObject wifiPanel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject proposPanel;

    [SerializeField] private GameObject wifiTxt;

    [SerializeField] private GameObject notif;
    public static bool hasEvent = false;


}
