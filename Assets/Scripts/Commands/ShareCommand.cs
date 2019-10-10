using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class ShareCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}

		public override void Execute()
		{
			NativeShare newShare = new NativeShare();
			newShare.AddFile(Application.persistentDataPath + "/" + "ScreenShot");
			newShare.Share();
			uIManager.shareView.Hide(true);
		}
	}
}
