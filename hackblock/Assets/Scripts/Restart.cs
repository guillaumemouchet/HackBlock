using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restart()
    {
        //Player restart life
        PlayerLife player = PlayerLife.Instance;
        player.restart();
        SceneManager.LoadScene("MainWindow");
    }
}
