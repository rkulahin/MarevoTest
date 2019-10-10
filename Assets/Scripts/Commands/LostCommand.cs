using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;
using Views;

namespace Commands
{
	public class LostCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}

		public override void Execute()
		{
			uIManager.photoView.Hide(true);
			uIManager.seekView.Hide(false);
		}
	}
}
