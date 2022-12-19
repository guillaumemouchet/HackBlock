/*
 * Title : Application Mail 
 * Authors : Guillaume Mouchet 
 * Date : 08.12.2022
 * Source : 
 */
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ApplicationMail : MonoBehaviour
{
    /***************************************************************\
     *                      Methodes private                       *
    \***************************************************************/
    private void OnEnable()
    {

        if (ApplicationSettings.hasEvent)
        {
            // no wifi
            noWifiPanel.SetActive(true);

        }else if (hasEvent)
        {
            //Choisir un des evenements au hasard
            int test = Random.Range(1,12);
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
                    subject = "Your adress is good to go";
                    from = "Netflix";
                    mail = "neflix@support.com";
                    content = "Hi Guillaume,\r\n\v As requested, your email has been updated. Sign in with your new email from now. \r\n\v If you DID NOT make this change, please contact us via phone. We can be reached at 877.Netflix.411 and phone support is available 24/7 \r\v\n Thanks for watching,\r\n\v The netflix Team";
                    answer = "Call the number";
                    mailType = MailType.LINK;
                    infected = true;
                    break;
                case 2:
                    subject = "Package in transit";
                    from = "Poste";
                    mail = "poste@jfkdsjfeiwfsknckjdsjh.fr";
                    content = "Dear Customer,\r\nYour package have been stuck in transit and the customs are retaining it for missing documents.\r\nTo receive your package you need to send 100 Euro, you�ll find the payment on the your account :\r\nhttp://www.postee.fr/account/user/X849375987695\r\nThe payment must be done in the following 3 days or the customs will destroy the package,\r\nBest regards,\r\nYour postal service\r\n"; 
                    answer = "Click the link and find the paiment plan";
                    mailType = MailType.LINK;
                    infected = true;
                    break;
                case 3:
                    subject = "Informations sur la GameJam";
                    from = "Haute �cole Arc";
                    mail = "gamejam@hearc.ch";
                    content = "Chers �l�ves,\r\nComme vous le savez, la Game Jam arrive � grands pas, pour cela nous vous demandons de bien vouloir nous envoyer un mail pour nous confirmer votre pr�sence.\r\nPour rappel les dates sont du 19-21 novembre 2023 avec la possibilit� de rester dormir la nuit sur le campus.\r\nMeilleures salutations et au plaisir de vous voir nombreux,\r\nGuillaume Mouchet\r\n";
                    answer = "Respond to the Email";
                    mailType = MailType.OTHER;
                    infected = false;
                    break;
                case 4:
                    subject = "Conf�rence Horlogerie";
                    from = "Haute �cole Arc";
                    mail = "arc-holo@hearc.ch";
                    content = "Bonjour � toutes et � tous !\r\nL�association Arc-Horlo a le plaisir de vous annoncer la venue de Alain Schiesser pour nous pr�senter sa soci�t� Le Cercle des Horlogers. Elle a notamment collabor� avec des marques telles que : Jacob&Co, Trilobe, Code 41 et bien d�autres.\r\nCette conf�rence abordera les th�mes suivants : son parcours professionnel, pr�sentation de la soci�t�, processus de d�veloppement d�une montre et la pr�sentation d�une cr�ation.\r\nLa conf�rence se d�roulera le jeudi 17 novembre 2022 � 18h au Campus Arc 2 en salle 320.\r\nSi vous �tes int�ress�, veuillez s�il vous pla�t vous inscrire via la pi�ce jointe et la renvoyer par mail avant le 12 novembre.\r\nLa conf�rence est ouverte � tout le monde et nous vous attendons nombreux !\r\nL'�quipe Arc-Horlo\r\n\r\n";
                    answer = "Download the attachement";
                    mailType = MailType.ATTACHMENT;
                    infected = false;
                    break;
                case 5:
                    subject = "Banque - UBS";
                    from = "UBS";
                    mail = "thewebmaster@ubs.fr";
                    content = "Cher [[name]],\r\nUBS est fi�re de vous annoncer une modification de son syst�me de s�curit�.\r\nPour cela nous vous demandons de t�l�charger la pi�ce jointe pour avoir plus de d�tail sur l'op�ration.\r\nMeilleures salutations,\r\nL��quipe UBS\r\n\r\n";
                    answer = "Download the attachement";
                    mailType = MailType.ATTACHMENT;
                    infected = true;
                    break;
                case 6:
                    subject = "Paiement de la GameJam";
                    from = "Haute �cole Arc";
                    mail = "gamejam@hearc.ch";
                    content = "Chers �l�ves,\r\nAvec la GameJam arrivant � grands pas je vous prierai de bien vouloir vous acquitter de la taxe de participation de 8.- en faisant un paiement � :\r\nGuillaume Mouchet\r\nUBS\r\nRue de l'�vole 12\r\nCH 0 0000 0000 0000 0000 0\r\nSuisse\r\nMeilleures salutations et au plaisir de vous voir nombreux,\r\nGuillaume Mouchet\r\n\r\n";
                    answer = "Respond and send the money";
                    mailType = MailType.OTHER;
                    infected = false;
                    break;
                case 7:
                    subject = "compte steam bloqu�";
                    from = "Steam Customer service";
                    mail = "customer@stem.fr";
                    content = "Bonjour,\r\nSuite � de nombreuses plaintes sur votre compte pour mauvais comportement l'�quipe Steam � d�cider de le bloquer.\r\nAfin de pouvoir acc�s � votre compte, nous vous demandons de bien vouloir nous envoyer votre nom de compte ainsi que votre mot de passe, que nous puissions lancer les d�marches.\r\nEn cas de non-r�ponse dans les 5 jours, nous nous verrons oblig�s de supprimer d�finitivement votre compte, et donc votre biblioth�que.\r\nL'�quipe Steam\r\n\r\n";
                    answer = "Respond with your personnal informations";
                    mailType = MailType.OTHER;
                    infected = true;
                    break;
                case 8:
                    subject = "un ptit verre? ;^)";
                    from = "Guillaume";
                    mail = "guillaume@outlook.com";
                    content = "Hello,\r\ncomment tu vas depuis le temps ?\r\n�a te dis d�aller boire un petit verre vendredi soir apr�s les cours : ).\r\nOn se dit l�Univers � 16h30 ?\r\nPlein de bisous,\r\nGuillaume\r\n";
                    answer = "Answer you'll come";
                    mailType = MailType.OTHER;
                    infected = false;
                    break;
                case 9:
                    subject = "Urgent business proposal";
                    from = "Prince Jones Dimka";
                    mail = "princeJonesDimka@outlook.com";
                    content = "Dear Sir, We have thirty million us dollars which we got from over inflated contract of crude oil contract awarded to foreign contractors in the Nigerian national petroleum corporation. We are seeking your assistance and permission to remit this amount into your account. Your commission is thirty percent of the money.\r\nPlease notify me your acceptance to do this business urgently. The men involved are men in government. More details will be sent to you by email. Please forward your personal phone number, address and email.\r\nContact me URGENTLY,\r\nThanks for your co-operation,\r\nYou faithfully,\r\nPrince Jones Dimka\r\n";
                    answer = "Accept the money";
                    mailType = MailType.NORMAL;
                    infected = true;
                    break;
                case 10:
                    subject = "Need your assistant in your country";
                    from = "Maria DEl Pilar Rezola";
                    mail = "mariadelpilarezola001@gmail.com";
                    content = "Dear Friend,\r\n\r\nI came across your e-mail contact prior a private search while in need of your assistance. My name is Aisha  Al-Gaddafi a single Mother and a Widow with three Children. I am the only biological Daughter of late Libyan President (Late Colonel Muammar Gaddafi).\r\n\r\nI have investment funds worth Twenty Seven Million Five Hundred Thousand United State Dollar ($27.500.000.00 ) and i need a trusted investment Manager/Partner because of my current refugee status, however, I am interested in you for investment project assistance in your country,\r\n\r\n\r\nYour Urgent Reply Will Be Appreciated. contact me at this email  address ( aishaelgaddafi@hotmail.com )  for further discussion.\r\n\r\nBest Regards\r\nMrs Aisha Al-Gaddafi";
                    answer = "Accept the deal";
                    mailType = MailType.NORMAL;
                    infected = true;
                    break;
                case 11:
                    subject = "HELP";
                    from = "Guillaume";
                    mail = "guillaume@outlook.com";
                    content = "Hello,\r\nJe suis coinc� dans un autre pays et j�aurais besoin d�argent en urgence, est ce que tu peux m�envoyer 500 francs par ce site http://www.twiint.com/send/user que je puisse m�acheter un billet d�avion,\r\nAide moi,\r\nGuillaume\r\n";
                    answer = "Send the money";
                    mailType = MailType.NORMAL;
                    infected = true;
                    break;
                default:
                    subject = "Your adress is good to go";
                    from = "Netflix";
                    mail = "neflix@support.com";
                    content = "Hi Guillaume,\r\n\v As requested, your email has been updated. Sign in with your new email from now. \r\n\v If you DID NOT make this change, please contact us via phone. We can be reached at 877.Netflix.411 and phone support is available 24/7 \r\v\n Thanks for watching,\r\n\v The netflix Team";
                    answer = "Call the number";
                    mailType = MailType.LINK;
                    infected = true;
                    break;
            }
            //Creer l'�v�nements 
            mailEvent = new MailEvent(subject, from, mail, content, answer, infected, mailType);

            inFromMain.GetComponent<TextMeshProUGUI>().text = from;
            inSubjectMain.GetComponent<TextMeshProUGUI>().text = subject;
            event1Panel.SetActive(false);
            mainPanel.SetActive(true);
            noWifiPanel.SetActive(false);

        }
        else
        {
            event1Panel.SetActive(false);
            mainPanel.SetActive(true);
            noWifiPanel.SetActive(false);
            //montrer le pannel de base disant qu'il n'y a pas de mail
            inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
            inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";

        }
}


    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/
    public void onListClick()
    {
        if (hasEvent)
        {
            event1Panel.SetActive(true);
            mainPanel.SetActive(false);
            validate.SetActive(true);
            returnBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Delete the mail";

            //Changer le event panel pour avoir les valeur de mail event$
            InFrom.GetComponent<TextMeshProUGUI>().text = mailEvent.getFrom();
            InSubject.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getSubject();
            InText.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getText();
            InMail.GetComponentInChildren<TextMeshProUGUI>().text = mailEvent.getMail();
            
            //Changer les boutton return et validate pour correspondre au pannel et cr�er les actions
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

    public void OnLinkClick()
    {
        if (clickLink == 0)
        {
            switch (mailEvent.getMailType())
            {
                case MailType.OTHER:
                    Application.OpenURL(answerLinkBtn.GetComponentInChildren<TextMeshProUGUI>().text);
                    answerOtherBtn.SetActive(false);
                    break;
                case MailType.NORMAL:
                    Application.OpenURL(answerLinkBtn.GetComponentInChildren<TextMeshProUGUI>().text);
                    answerNormalBtn.SetActive(false);
                    break;
                case MailType.ATTACHMENT:
                    Application.OpenURL(answerLinkBtn.GetComponentInChildren<TextMeshProUGUI>().text);
                    answerAttachmentBtn.SetActive(false);
                    break;
                case MailType.LINK:
                    answerLinkText.GetComponent<TextMeshProUGUI>().text = "What did we just say about links that should not be followed unless the source is reliable? If in any doubt you have to do the research yourself on the internet, in this case you can type in your search bar: �Have i been pwned� or click on the following link if you trust me.";
                    break;
            }
            clickLink++;
        }
        else if(clickLink== 1)
        {
            switch (mailEvent.getMailType())
            {
                case MailType.OTHER:
                    break;
                case MailType.NORMAL:
                    break;
                case MailType.ATTACHMENT:
                    break;
                case MailType.LINK:
                    Application.OpenURL(answerLinkBtn.GetComponentInChildren<TextMeshProUGUI>().text);
                    answerLinkReturn.SetActive(true);
                    answerLinkBtn.SetActive(false);
                    break;
            }

        }
        returnBtn.SetActive(true);

        //montrer le pannel de base disant qu'il n'y a pas de mail
        returnBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Return";
        inFromMain.GetComponent<TextMeshProUGUI>().text = "You have no mail";
        inSubjectMain.GetComponent<TextMeshProUGUI>().text = "Take a rest and go outside";


    }

    /***************************************************************\
     *                      Attributes private                     *
    \***************************************************************/

    [SerializeField] private GameObject event1Panel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject noWifiPanel;

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

    [SerializeField] private GameObject answerNormalText;
    [SerializeField] private GameObject answerNormalBtn;
    [SerializeField] private GameObject answerNormalReturn;

    private static MailEvent mailEvent = null;
    public static bool hasEvent = false;
    private int clickLink = 0;


}
