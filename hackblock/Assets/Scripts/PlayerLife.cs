/*
 * Title : PlayerLife 
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class PlayerLife : MonoBehaviour
{

    /***************************************************************\
    *                      Methodes private                       *
   \***************************************************************/

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

    private void displayLife()
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

    private bool checkIfDead()
    {
        if(totalLife<=0)
        {
            return true;
        }
        return false;
    }
    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/


    public void looseLife()
    {
        totalLife--;
        displayLife();
    }

    public void restart()
    {
        totalLife = 3;
        displayLife();
    }
    public void Update()
    {
        displayLife();
        if (checkIfDead())
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Retrieve the name of this scene.
            string sceneName = currentScene.name;

            if (sceneName == "EndGame")
            {
                //DO nothing
            }
            else
            {
                SceneManager.LoadScene("EndGame");
            }
        }

    }

    /***************************************************************\
    *                      Attributes private                     *
    \***************************************************************/


    public static PlayerLife Instance;

    [SerializeField] GameObject life1;
    [SerializeField] GameObject life2;
    [SerializeField] GameObject life3;

    List<GameObject> lifeList;
    public int totalLife;
}
