using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public  class PlayerLife : MonoBehaviour
{

    public static PlayerLife Instance { get; private set; }

    [SerializeField] GameObject Test;
    int totalLife = 3;
    bool isDead = false;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void displayLife()
    {
        Test.GetComponent<TextMeshProUGUI>().text = totalLife.ToString();
    }

    public void checkIfDead()
    {
        if(totalLife<=0)
        {
            isDead = true;
        }
    }

    public void looseLife()
    {
        totalLife--;
    }

    private void Update()
    {
        displayLife();

        if(isDead)
        {
            //TODO DISPLAY LA PAGE DE MORT
            Debug.Log("TEST FIN DE MORT");
        }
    }
}
