using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionSocialNetwork : MonoBehaviour
{

    public void ReturnClick()
    {
            Debug.Log("Main");
            SceneManager.LoadScene("MainWindow");
    }

}
