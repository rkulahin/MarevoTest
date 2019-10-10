using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;
using System.Threading;

namespace Commands
{
	public class PhotoCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}
		// private Timer timerTime;
		public override void Execute()
		{
			// if (timerCallback == null)
				//  timerCallback = new TimerCallback(ActiveScreen);
			DeactiveScreen();
			ScreenCapture.CaptureScreenshot("ScreenShot");
			ActiveScreen();
			//  timerTime = new Timer(Callback, uIManager, 500, Timeout.Infinite);
		}

		private void DeactiveScreen()
		{
			Debug.Log("DeactiveScreen");
			uIManager.menuView.Hide();
			uIManager.shareView.Hide(true);
			uIManager.photoView.Hide(true);
		}
		private void ActiveScreen()
		{
			Debug.Log("ActiveScreen");
			uIManager.shareView.Hide(false);
			uIManager.menuView.Hide(false);
			uIManager.photoView.Hide(false);
		}

		// private void Callback(object state)
		// {
		// 	ActiveScreen();
		// }

	}
}