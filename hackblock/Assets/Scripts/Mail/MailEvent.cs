using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
public enum MailType
{
    LINK,
    ATTACHMENT,
    OTHER,
    NORMAL
}
public class MailEvent : Component
{
    private string subject;
    private string from;
    private string mail;
    private string content;
    private string answer;
    private bool isInfected;
    private MailType mailType;
    
    public MailEvent(string subject, string from, string mail, string content, string answer, bool isInfected, MailType mailType)
    {


        this.subject = subject;
        this.from = from;
        this.answer = answer;
            
        this.mail = mail;
        this.content = content;
        this.isInfected = isInfected;
        this.mailType = mailType;

    }

    public string getSubject()
    {
        return subject;
    }
    public string getAnswer()
    {
        return answer;
    }

    public string getFrom()
    {
        return from;
    }

    public string getMail()
    {
        return mail;
    }

    public string getText()
    {
        return content;
    }
        
    public bool getIsInfected()
    {
        return isInfected;
    }
    public MailType getMailType()
    {
        return mailType;
    }

}
