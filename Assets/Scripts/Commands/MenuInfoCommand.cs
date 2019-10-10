using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class MenuInfoCommand : Command
	{
		[Inject] public GameObject infoPanel {get;set;}
		[Inject] public UIManager uIManager {get;set;}

		public override void Execute()
		{ 
			infoPanel.SetActive(true);
			Debug.Log("Info Menu");
		}
	}
}
