using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class FindCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}
		[Inject] public GameObject wolf {get;set;}
		public override void Execute()
		{
			// wolf.transform.LookAt(Vector3.zero);
			uIManager.seekView.Hide(true);
			uIManager.photoView.Hide(false);
		}
	}
}
