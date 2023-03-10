/*
 * Title : ApplicationSearch
 * Authors : Guillaume Mouchet 
 * Date : 12.12.2022
 * Source : 
 */

using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationSearch : MonoBehaviour
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
        }
        else if (hasEvent)
        {
            //Choose an event at random
            int test = Random.Range(1, 2);

            switch (test)
            {
                case 1:
                    defaultPanel.SetActive(false);
                    lostPanel.SetActive(false);
                    verifyPanel.SetActive(false);
                    amazonPanel.SetActive(true);
                    noWifiPanel.SetActive(false);
                    validateBtn.SetActive(true);
                    break;
                case 2:
                    // googlePanel.SetActive(true);
                    break;
            }
        }
        else
        {
            //Create a simple search engine that redirects on the internet
            defaultPanel.SetActive(true);
            lostPanel.SetActive(false);
            verifyPanel.SetActive(false);
            amazonPanel.SetActive(false);
            noWifiPanel.SetActive(false);
        }

    }



    /***************************************************************\
     *                      Methodes publiques                     *
    \***************************************************************/
    public void onReturnClick()
    {
        SceneManager.LoadScene("MainWindow");
    }
    public void onValidateClick()
    {
        if (username != "")
        {
            Debug.Log(name);
            if (surname != "")
            {
                Debug.Log(surname);
                if (email != "")
                {
                    Debug.Log(email);
                    if (adress != "")
                    {
                        Debug.Log(adress);

                        if (pass == conPass && pass != "")
                        {
                            Debug.Log(pass + " " + conPass);
                            if (isChecked)
                            {
                                //Do something with the fact that the player read or not the tearms
                                if (hasReadTerms)
                                {
                                    //open the verification
                                    Debug.Log("has read");
                                    amazonPanel.SetActive(false);
                                    verifyPanel.SetActive(true);
                                    validateBtn.SetActive(false);
                                    returnBtn.SetActive(false);
                                    hasEvent = false;

                                }
                                else
                                {
                                    //Go to the wrong answer panel
                                    lostPanel.SetActive(true);
                                    validateBtn.SetActive(false);
                                    amazonPanel.SetActive(false);
                                    hasEvent = false;

                                    //Player loose life
                                    PlayerLife player = PlayerLife.Instance;
                                    player.looseLife();
                                }

                            }
                        }
                    }
                }
            }
        }
    }


    public void validateName()
    {
        username = nameInput.GetComponent<TMP_InputField>().text;
        //If we find anything other than letters it doesn't work
        if (Regex.IsMatch(name, "[^a-zA-Z ]+"))
        {
            textName.SetActive(true);
            username = "";
        }
        else
        {
            Debug.Log("name is ok");
            textName.SetActive(false);
        }

    }
    public void validateSurname()
    {
        surname = surnameInput.GetComponent<TMP_InputField>().text;
        //If we find anything other than letters it doesn't work

        if (Regex.IsMatch(surname, "[^a-zA-Z ]+"))
        {
            textSurname.SetActive(true);
            surname = "";
        }
        else
        {
            Debug.Log("Surname is ok");
            textSurname.SetActive(false);
        }
    }
    public void validateEmail()
    {
        email = emailInput.GetComponent<TMP_InputField>().text;
        if (Regex.IsMatch(email, "^[a-zA-Z0-9]+(?:\\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z0-9]+)*$"))
        {
            Debug.Log("email is ok");
            textEmail.SetActive(false);

        }
        else
        {
            textEmail.SetActive(true);
            email = "";
        }
    }
    public void validateAdress()
    {
        adress = adressInput.GetComponent<TMP_InputField>().text;
        if (Regex.IsMatch(adress, "\\w+.,.[0-9]+"))
        {
            Debug.Log("adress is ok");
            textAdress.SetActive(false);
        }
        else
        {
            textAdress.SetActive(true);
            adress = "";
        }
    }
    public void validatePassword()
    {
        pass = passInput.GetComponent<TMP_InputField>().text;
        if (pass.Length > 6)
        {
            Debug.Log("ok");
            textPass.GetComponent<TextMeshProUGUI>().color = Color.black;

        }
        else
        {
            passInput.GetComponent<TMP_InputField>().text = "";
            textPass.GetComponent<TextMeshProUGUI>().color = Color.red;
            pass = "";
        }
    }

    public void validateConfirmPassword()
    {
        conPass = conPassInput.GetComponent<TMP_InputField>().text;
        if (pass == conPass)
        {
            Debug.Log("passwords are the same");
            textConPass.SetActive(false);

        }
        else
        {
            conPassInput.GetComponent<TMP_InputField>().text = "";
            textConPass.SetActive(true);
            conPass = "";
        }
    }

    public void validateDate()
    {
        string correctDate = "11/05/2021";
        string date = dateInput.GetComponent<TMP_InputField>().text;
        if (Regex.IsMatch(date, "(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)[0-9]{2}"))
        {
            Debug.Log("ok");
            if (correctDate == date)
            {
                //End the game and go back to the mainPage.
                SceneManager.LoadScene("MainWindow");
            }
            else
            {
                //Go to the wrong answer panel
                lostPanel.SetActive(true);
                verifyPanel.SetActive(false);
                validateBtn.SetActive(false);
                returnBtn.SetActive(true);
                //Player loose life
                PlayerLife player = PlayerLife.Instance;
                player.looseLife();
            }
        }
        else
        {
            dateInput.GetComponent<TMP_InputField>().text = "";
        }
    }


    public void searchOnInternet()
    {
        string search = internetInput.GetComponent<TMP_InputField>().text;
        search.Replace(" ", "+");
        Application.OpenURL("https://www.google.com/search?q=" + search);
    }

    public void searchOnMKM()
    {
        string search = mkmInput.GetComponent<TMP_InputField>().text;
        search = search.Replace(" ", "-");
        Debug.Log(search);
        Application.OpenURL("https://www.cardmarket.com/fr/Magic/Cards/"+search+"/Versions");
    }
    public void onWrite()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
    public void onWriteEmail()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.EmailAddress);
    }
    public void onWriteSecret()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default,false, false,true);
    }
    public void onConditionClick()
    {
        hasReadTerms = true;
        Application.OpenURL("https://www.amazon.com/gp/help/customer/display.html?nodeId=G2B9L3YR7LR8J4XP");
    }

    public void OnConditionToggle()
    {
        //Open a web page with terms and conditions or create my own page
        Debug.Log("click");
        isChecked = !isChecked;

    }

    /***************************************************************\
     *                      Attributes private                     *
    \***************************************************************/


    [SerializeField] private GameObject amazonPanel;
    [SerializeField] private GameObject verifyPanel;
    [SerializeField] private GameObject lostPanel;
    [SerializeField] private GameObject defaultPanel;
    [SerializeField] private GameObject noWifiPanel;


    [SerializeField] private GameObject nameInput;
    [SerializeField] private GameObject surnameInput;
    [SerializeField] private GameObject emailInput;
    [SerializeField] private GameObject adressInput;
    [SerializeField] private GameObject passInput;
    [SerializeField] private GameObject conPassInput;
    [SerializeField] private GameObject dateInput;

    [SerializeField] private GameObject internetInput;
    [SerializeField] private GameObject mkmInput;


    [SerializeField] private GameObject textName;
    [SerializeField] private GameObject textSurname;
    [SerializeField] private GameObject textEmail;
    [SerializeField] private GameObject textAdress;
    [SerializeField] private GameObject textPass;
    [SerializeField] private GameObject textConPass;

    [SerializeField] private GameObject validateBtn;
    [SerializeField] private GameObject returnBtn;

    public static bool hasEvent = false;

    private string username = "";
    private string surname = "";
    private string email = "";
    private string adress = "";
    private string pass = "";
    private string conPass = "";
    private bool hasReadTerms = false;
    private bool isChecked = false;

}