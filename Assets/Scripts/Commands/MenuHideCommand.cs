using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class MenuHideCommand : Command
	{
		[Inject] public GameObject menuPanel {get;set;}
		[Inject] public UIManager uIManager {get;set;}

		public override void Execute()
		{
			Debug.Log("Hide Menu");
			uIManager.menuView.Hide(false);
			menuPanel.SetActive(false);
		}
	}
}
