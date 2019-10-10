using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailSender : MonoBehaviour
{
    public void SendEmail(string mail)
	{
		Debug.Log("Send Mail");
		// string email = "rostislavkulagin@gmai.com";
		string email = "vb@marevo.vision";
		string subject = MyEscapeURL("Test My APP");
		Debug.Log("URL " + subject);
		string body = MyEscapeURL(mail);
		
		Application.OpenURL ("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}  
	private string MyEscapeURL (string URL)
	{
		Debug.Log("URL " + URL);
		return WWW.EscapeURL(URL).Replace("+","%20");
	}
}
