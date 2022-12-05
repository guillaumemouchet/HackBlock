using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionSocialNetwork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.OpenURL("https://www.instagram.com");
    }

    public void ReturnClick()
    {
            Debug.Log("Main");
            SceneManager.LoadScene("MainWindow");

    }

}
