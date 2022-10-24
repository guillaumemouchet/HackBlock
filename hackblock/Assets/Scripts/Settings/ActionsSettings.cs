using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionsSettings : MonoBehaviour
{

    [SerializeField] private Button returnBtn;
    [SerializeField] private Button ValidateBtn;
    [SerializeField] private GameObject wifiPanel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject proposPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
