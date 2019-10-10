using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.mediation.api;
using Signals;

namespace Views
{
	public class MenuMediator : Mediator
	{
		[Inject] public MenuView menuView {get;set;}
		[Inject] public MenuSignal menuSignal {get;set;}
		[Inject] public MenuHideSignal menuHideSignal {get;set;}
		[Inject] public MenuSoundSignal menuSoundSignal {get;set;}
		[Inject] public MenuInfoSignal menuInfoSignal {get;set;}
		[Inject] public MenuMailSignal menuMailSignal {get;set;}
		 
		public override void OnRegister()
		{
			base.OnRegister();
			menuView.MenuHideSignal.AddListener(ClickHideMenu);
			menuView.MenuInfoSignal.AddListener(ClickInfo);
			menuView.MenuMailSignal.AddListener(ClickMail);
			menuView.MenuSoundSignal.AddListener(ClickSound);
			menuView.MenuSignal.AddListener(ClickMenu);
		}

		public override void OnRemove()
		{
			base.OnRemove();
			menuView.MenuHideSignal.RemoveListener(ClickHideMenu);
			menuView.MenuInfoSignal.RemoveListener(ClickInfo);
			menuView.MenuMailSignal.RemoveListener(ClickMail);
			menuView.MenuSoundSignal.RemoveListener(ClickSound);
			menuView.MenuSignal.RemoveListener(ClickMenu);
		}

		private void ClickMenu()
		{
			menuSignal.Dispatch(menuView.menuPanel);
		}
		private void ClickInfo()
		{
			menuInfoSignal.Dispatch(menuView.infoPanel);
		}

		private void ClickSound()
		{
			menuSoundSignal.Dispatch();
		}

		private void ClickMail()
		{
			menuMailSignal.Dispatch(menuView.inputField, menuView.sendButton);
		}

		private void ClickHideMenu()
		{
			menuHideSignal.Dispatch(menuView.menuPanel);
		}
	}
}