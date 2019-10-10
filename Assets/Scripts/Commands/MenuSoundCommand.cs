using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class MenuSoundCommand : Command
	{
		[Inject] public UIManager uIManager {get;set;}
		[Inject] public SoundManager soundManager {get;set;}
		public override void Execute()
		{
			soundManager.audioSource.mute = !soundManager.audioSource.mute;
			Debug.Log("Mute " + soundManager.audioSource.mute);
		}
	}
}
