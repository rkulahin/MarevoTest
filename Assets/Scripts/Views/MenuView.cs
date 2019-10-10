using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.signal.impl;

namespace Views
{
	public class MenuView : MainView
	{
		[SerializeField] private Button _menuButton;
		[SerializeField] private Button _menuHideButton;
		[SerializeField] private Button _soundButton;
		[SerializeField] private Button _infoButton;
		[SerializeField] private Button _mailButton;
		public GameObject inputField;
		public GameObject menuPanel;
		public GameObject infoPanel;
		public Button sendButton;
		public Signal MenuSignal = new Signal();
		public Signal MenuSoundSignal = new Signal();
		public Signal MenuInfoSignal = new Signal();
		public Signal MenuMailSignal = new Signal();
		public Signal MenuHideSignal = new Signal();
		protected override void Start()
		{
			base.Start();
			_infoButton.onClick.AddListener(ClickInfo);
			_mailButton.onClick.AddListener(ClickMail);
			_soundButton.onClick.AddListener(ClickSound);
			_menuButton.onClick.AddListener(ClickMenu);
			_menuHideButton.onClick.AddListener(ClickHideMenu);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			_infoButton.onClick.RemoveListener(ClickInfo);
			_mailButton.onClick.RemoveListener(ClickMail);
			_soundButton.onClick.RemoveListener(ClickSound);
			_menuButton.onClick.RemoveListener(ClickMenu);
			_menuHideButton.onClick.RemoveListener(ClickHideMenu);
		}

		private void ClickMenu()
		{
			MenuSignal.Dispatch();
		}

		private void ClickInfo()
		{
			MenuInfoSignal.Dispatch();
		}

		private void ClickSound()
		{
			MenuSoundSignal.Dispatch();
		}

		private void ClickMail()
		{
			MenuMailSignal.Dispatch();
		}

		private void ClickHideMenu()
		{
			MenuHideSignal.Dispatch();
		}
		
		public void Hide()
		{
			this.Hide(true);
			menuPanel.SetActive(false);
		}
	}
}
