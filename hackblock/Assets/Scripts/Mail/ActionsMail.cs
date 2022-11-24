using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionsMail : MonoBehaviour
{

    [SerializeField] private GameObject returnBtn;
    [SerializeField] private GameObject validateBtn;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject eventPanel;
    [SerializeField] private GameObject answerLink;
    [SerializeField] private GameObject answerAttachment;
    [SerializeField] private GameObject answerOther;
    [SerializeField] private GameObject answerNormal;

    [SerializeField] private GameObject inFromMain;
    [SerializeField] private GameObject inSubjectMain;


    public void ReturnClick()
    {

            if (mainPanel.gameObject.activeInHierarchy)
            {
                Debug.Log("Main");
                SceneManager.LoadScene("MainWindow");

            }else if(eventPanel.gameObject.activeInHierarchy)
            {

                mainPanel.SetActive(true);
                inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
                inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";
                returnBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Return";

                eventPanel.SetActive(false);
                answerLink.SetActive(false);
                answerAttachment.SetActive(false);
                answerNormal.SetActive(false);
                answerOther.SetActive(false);
            }
        returnBtn.SetActive(true);

        //Remove validate
        validateBtn.SetActive(false);
    }
    public void ValidateClick()
    {
        MailEvent mailEvent = ApplicationMail.GetMailEvent();

        //remove validate
        validateBtn.SetActive(false);
        //remove return to not have return at the wrong moments
        returnBtn.SetActive(false);

        if (mailEvent.getIsInfected())
        {
            //the mail is infected, a validation was not a good idea, explications and the player loose 1 life
            switch (mailEvent.getMailType())
            {
                case MailType.OTHER:
                    answerOther.SetActive(true);
                    break;
                case MailType.NORMAL:
                    answerNormal.SetActive(true);
                    break;
                case MailType.ATTACHMENT:
                    answerAttachment.SetActive(true);
                    break;
                case MailType.LINK:
                    answerLink.SetActive(true);
                    break;
            }
            //Player loose life
            PlayerLife player = PlayerLife.Instance;
            player.looseLife();

        }
        else
        {
            //the mail was not infected so the player made the right choice
            mainPanel.SetActive(true);
            eventPanel.SetActive(false);
            returnBtn.SetActive(true);
            inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
            inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";
            returnBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Return";

        }

    }
}
