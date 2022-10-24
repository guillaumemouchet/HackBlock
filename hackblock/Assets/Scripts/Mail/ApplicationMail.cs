using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static Unity.VisualScripting.Member;
using static UnityEditor.ShaderData;
using Application = UnityEngine.Application;
using Random = UnityEngine.Random;

public class ApplicationMail : MonoBehaviour
{
    [SerializeField] private GameObject event1Panel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject validate;
    [SerializeField] private GameObject returnBtn;

    [SerializeField] private GameObject InMail;
    [SerializeField] private GameObject InText;
    [SerializeField] private GameObject InSubject;
    [SerializeField] private GameObject InFrom;

    [SerializeField] private GameObject inFromMain;
    [SerializeField] private GameObject inSubjectMain;

    [SerializeField] private GameObject answerLinkText;
    [SerializeField] private GameObject answerLinkBtn;
    [SerializeField] private GameObject answerLinkReturn;

    [SerializeField] private GameObject answerAttachmentText;
    [SerializeField] private GameObject answerAttachmentBtn;
    [SerializeField] private GameObject answerAttachmentReturn;

    [SerializeField] private GameObject answerOtherText;
    [SerializeField] private GameObject answerOtherBtn;
    [SerializeField] private GameObject answerOtherReturn;


    private static MailEvent mailEvent = null;
    public static bool hasEvent = false;


    private void OnEnable()
    {
        if (hasEvent)
        {
            //Choisir un des evenements au hasard
            int test = Random.Range(3,4);
            string subject = "";
            string from = "";
            string mail = "";
            string content = "";
            string answer = "";
            MailType mailType = MailType.OTHER;
            bool infected = false;
            switch (test)
            {
                case 1:
                    subject = "Totally not a scam";
                    from = "Friend";
                    mail = "friend@thisisasscam.xyz";
                    content = "Dear Guillaume,\r\n\vCan you send me some money by following the link ? I’m quite in a hurry stuck in another country !\r\n\r\nhttp://www.ImGonnaTakeYourPersonnalInformation.DoNotTrustMe\v\vBest regards,\r\nTotally Not your Friend \r\n";
                    answer = "Accept the Email and follow the link";
                    mailType = MailType.LINK;
                    infected = true;
                    break;
                case 2:
                    subject = "Package in transit";
                    from = "Poste";
                    mail = "poste@jfkdsjfeiwfsknckjdsjh.fr";
                    content = "Dear Customer,\r\nYour package have been stuck in transit and the customs are retaining it for missing documents.\r\nTo receive your package you need to send 100 Euro, you’ll find the payment on the your account :\r\nhttp://www.postee.fr/account/user/X849375987695\r\nThe payment must be done in the following 3 days or the customs will destroy the package,\r\nBest regards,\r\nYour post service\r\n";
                    answer = "Click the link and find the paiment plan";
                    mailType = MailType.LINK;
                    infected = false;
                    break;
                case 3:
                    subject = "Informations sur la GameJam";
                    from = "Haute école Arc";
                    mail = "gamejam@hearc.ch";
                    content = "Cher élèves,\r\nComme vous le savez la Game Jam arrive à grand pas, pour cela nous vous demandons de bien vouloir nous envoyer un mail pour nous confirmer votre présence.\r\nPour rappel les dates sont du 19-21 novembre 2023 avec la possibilité de rester dormir la nuit sur le campus,\r\nMeilleures salutations et au plaisir de vous voir nombreux,\r\nGuillaume Mouchet\r\n";
                    answer = "Respond to the Email";
                    mailType = MailType.OTHER;
                    infected = false;
                    break;
            }
            //Creer l'événements 
            mailEvent = new MailEvent(subject, from, mail, content, answer, infected, mailType);

            inFromMain.GetComponent<TextMeshProUGUI>().text = from;
            inSubjectMain.GetComponent<TextMeshProUGUI>().text = subject;

                     
        }
        else
        {
            //montrer le pannel de base disant qu'il n'y a pas de mail
            inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
            inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";

        }
}


    public void onListClick()
    {
        if (hasEvent)
        {
            event1Panel.SetActive(true);
            mainPanel.SetActive(false);
            validate.SetActive(true);


            //Changer le event panel pour avoir les valeur de mail event$
            InFrom.GetComponent<TextMeshProUGUI>().text = mailEvent.getFrom();
            InSubject.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getSubject();
            InText.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getText();
            InMail.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getMail();
            
            //Changer les boutton return et validate pour correspondre au pannel et créer les actions
            TextMeshProUGUI txt = validate.GetComponentInChildren<TextMeshProUGUI>();
            txt.text = mailEvent.getAnswer();

            hasEvent = false;
        }
    }
    public void setHasEvent(bool value)
    {
        hasEvent = value;
    }

    public static MailEvent GetMailEvent()
    {
        return mailEvent;
    }

    private int clickLink = 0;
    public void OnLinkClick()
    {
        if (clickLink == 0)
        {
            switch (mailEvent.getMailType())
            {
                case MailType.OTHER:
                    answerOtherText.GetComponent<TextMeshProUGUI>().text = "TESTETSSETSTTSET";
                    answerOtherBtn.GetComponent<TextMeshProUGUI>().text = "Other";

                    break;
                case MailType.NORMAL:

                    break;
                case MailType.ATTACHMENT:
                    answerAttachmentText.GetComponent<TextMeshProUGUI>().text = "Download the attachment?";
                    answerAttachmentBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Name of attachment";
                    break;
                case MailType.LINK:
                    answerLinkText.GetComponent<TextMeshProUGUI>().text = "Qu'est ce qu'on vient de dire sur les liens qui ne fallait pas suivre à moins que la source soit sûre ? \n En cas de doute il faut faire la recherche soit même sur internet, ici vous pouvez taper dans votre barre de recherche : \"Have i been pwned\" ou clicker sur le lien si vous me faites confiance.";
                    break;
            }
            clickLink++;
        }
        else if(clickLink== 1)
        {
            switch (mailEvent.getMailType())
            {
                case MailType.OTHER:
                    answerOtherReturn.SetActive(true);
                    answerOtherBtn.SetActive(false);
                    break;
                case MailType.NORMAL:

                    break;
                case MailType.ATTACHMENT:
                    answerAttachmentReturn.SetActive(true);
                    answerAttachmentBtn.SetActive(false);
                    break;
                case MailType.LINK:
                    Application.OpenURL(answerLinkBtn.GetComponentInChildren<TextMeshProUGUI>().text);
                    answerLinkReturn.SetActive(true);
                    answerLinkBtn.SetActive(false);
                    break;
            }

        }
        //montrer le pannel de base disant qu'il n'y a pas de mail
        inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
        inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";


    }
    // Update is called once per frame
    void Update()
    {
 
    }

}
