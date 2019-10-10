using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;
using Views;

namespace Commands
{
	public class StartCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}
		[Inject] public SoundManager soundManager {get;set;}
		public override void Execute()
		{
			uIManager.menuView.Hide(false);
			uIManager.seekView.Hide(false);
			uIManager.shareView.Hide(true);
			uIManager.photoView.Hide(true);
			soundManager.audioSource.clip = soundManager.IdleAudio;
		}
	}
}
