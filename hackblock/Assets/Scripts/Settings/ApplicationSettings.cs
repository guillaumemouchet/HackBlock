using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplicationSettings : MonoBehaviour
{
    [SerializeField] private GameObject wifiPanel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject proposPanel;
    [SerializeField] private Button proposBtn;
    [SerializeField] private Button wifiBtn;
    [SerializeField] private GameObject notif;
    public static bool hasEvent = false;


    private void OnEnable()
    {
        if (hasEvent)
        {
            notif.SetActive(true);
            TextMeshProUGUI txt = wifiPanel.GetComponentInChildren<TextMeshProUGUI>();
            txt.text = "Choose a new Wifi";
        }

    }
    
    public void wifiClick()
    {
        mainPanel.SetActive(false);
        wifiPanel.SetActive(true);
    }

    public void proposClick()
    {
        mainPanel.SetActive(false);
        proposPanel.SetActive(true);
    }
}
