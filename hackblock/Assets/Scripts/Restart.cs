/*
 * Title : Restart 
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/
    private void Update()
    {
        
    }
    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/

    public void restart()
    {
        //Player restart life
        PlayerLife player = PlayerLife.Instance;
        player.restart();
        SceneManager.LoadScene("MainWindow");
    }
    /***************************************************************\
      *                      Attributes private                     *
     \***************************************************************/

}
