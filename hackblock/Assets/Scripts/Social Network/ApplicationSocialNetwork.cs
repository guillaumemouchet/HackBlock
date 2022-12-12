using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationSocialNetwork : MonoBehaviour
{
    public static bool hasEvent = false;
    [SerializeField] private GameObject noWifiPanel;
    [SerializeField] private GameObject mainPanel;


    // Start is called before the first frame update
    void OnEnable()
    {

        if (ApplicationSettings.hasEvent)
        {
            // no wifi
            noWifiPanel.SetActive(true);
            mainPanel.SetActive(false);

        }
        else if (hasEvent)
        {
            mainPanel
                .SetActive(true);
            noWifiPanel.SetActive(false);

            Application.OpenURL("https://www.instagram.com");
        }
    }

}
