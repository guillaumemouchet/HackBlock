/*
 * Title : ApplicationSocialNetwork 
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */
using UnityEngine;

public class ApplicationSocialNetwork : MonoBehaviour
{
    /***************************************************************\
       *                      Methodes private                       *
      \***************************************************************/

    private void OnEnable()
    {

        if (ApplicationSettings.hasEvent)
        {
            // no wifi
            noWifiPanel.SetActive(true);
            mainPanel.SetActive(false);
        }
        else if (hasEvent)
        {
            mainPanel.SetActive(true);
            noWifiPanel.SetActive(false);

            Application.OpenURL("https://www.instagram.com");
        }
        mainPanel.SetActive(true);
        noWifiPanel.SetActive(false);
        hasEvent = false;
    }
    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/


     /***************************************************************\
      *                      Attributes private                     *
     \***************************************************************/


    public static bool hasEvent = false;
    [SerializeField] private GameObject noWifiPanel;
    [SerializeField] private GameObject mainPanel;


}
