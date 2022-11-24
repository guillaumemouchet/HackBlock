using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


[DisallowMultipleComponent]
public class ApplicationMainWindow : MonoBehaviour
{

        private void OnMouseUpAsButton()
    {
        Debug.Log("Touched " + this.transform.name);

        if (this.transform.name.Equals("Settings"))
        {
            SceneManager.LoadScene("Settings");
        } else if (this.transform.name.Equals("Mail"))
        {
            SceneManager.LoadScene("Mail");

        } else if (this.transform.name.Equals("Social Network"))
        {
            SceneManager.LoadScene("SocialNetwork");
        } else if (this.transform.name.Equals("Search Engine"))
        {
            SceneManager.LoadScene("SearchEngine");
        }

    }
}
