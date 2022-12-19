/*
 * Title : ActionSettings
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionsSettings : MonoBehaviour
{


    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/
    public void ReturnClick()
    {

            if (mainPanel.gameObject.activeInHierarchy)
            {
                Debug.Log("Main");
                SceneManager.LoadScene("MainWindow");

            }
            else if (proposPanel.gameObject.activeInHierarchy)
            {
                Debug.Log("Propos");
                mainPanel.SetActive(true);
                proposPanel.SetActive(false);
            }
            else if (wifiPanel.gameObject.activeInHierarchy)
            {
                Debug.Log("Wifi");
                mainPanel.SetActive(true);
                wifiPanel.SetActive(false);
            }

        

    }
    public void ValidateClick()
    {
        
    }



    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/


    /***************************************************************\
     *                      Attributes private                     *
    \***************************************************************/
    [SerializeField] private Button returnBtn;
    [SerializeField] private Button ValidateBtn;
    [SerializeField] private GameObject wifiPanel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject proposPanel;
}
