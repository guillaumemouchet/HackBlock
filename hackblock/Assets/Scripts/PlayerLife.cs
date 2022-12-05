using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public  class PlayerLife : MonoBehaviour
{

    public static PlayerLife Instance;

    [SerializeField] GameObject life1;
    [SerializeField] GameObject life2;
    [SerializeField] GameObject life3;

    List<GameObject> lifeList;
    public int totalLife;
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        lifeList = new List<GameObject>() {
               life1,
               life2,
               life3,
            };
        DontDestroyOnLoad(gameObject);
        
    }

    public void displayLife()
    {
        
        foreach (GameObject life in lifeList)
            {
                life.SetActive(false);
            }

        //Display or not the life
        for (int i = 0; i < totalLife; i++)
        {
            lifeList[i].SetActive(true);
        }
    }

    public bool checkIfDead()
    {
        if(totalLife<=0)
        {
            return true;
        }
        return false;
    }

    public void looseLife()
    {
        totalLife--;
        displayLife();
    }
    public void Update()
    {
        displayLife();
        if (checkIfDead())
        {
            SceneManager.LoadScene("EndGame");
            Destroy(this);
        }

    }
}
