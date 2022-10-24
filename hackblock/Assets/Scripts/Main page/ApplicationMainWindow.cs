using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationMainWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
            SceneManager.LoadScene("Social Network");
        } else if (this.transform.name.Equals("Search Engine"))
        {
            SceneManager.LoadScene("Search Engine");
        }

    }

    public void mailSprite()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject

    }
}
