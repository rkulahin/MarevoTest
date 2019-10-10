using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.command.impl;

namespace Commands
{
	public class MenuMailCommand : Command
	{
		[Inject] public GameObject inputField {get;set;}
		[Inject] public Button sendButton {get;set;}
		[Inject] public MailSender mailSender {get;set;}
		[Inject] public UIManager uIManager {get;set;}
		[Inject] public SoundManager soundManager {get;set;}
		private string _mailBody;
		private InputField _mailText;
		public override void Execute()
		{
			sendButton.onClick.AddListener(ClickSend);
			inputField.SetActive(true);
		}

		private void ClickSend()
		{
			if (_mailText == null)
				_mailText = inputField.GetComponent<InputField>();
			_mailBody = _mailText.text;
			mailSender.SendEmail(_mailBody);
			inputField.SetActive(false);
			sendButton.onClick.RemoveListener(ClickSend);

		}
	}
}
