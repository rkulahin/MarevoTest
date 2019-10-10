using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Commands
{
	public class DeactivateFigureCommand : Command
	{
		[Inject] public SoundManager soundManager {get;set;}
		[Inject] public Animator animator {get;set;}
		public override void Execute()
		{
			Debug.Log("Deactivate Figure");
			soundManager.audioSource.clip = soundManager.IdleAudio;
			if (!soundManager.audioSource.isPlaying)
			{
				soundManager.audioSource.Play();
			}
			animator.SetBool("Run", false);
		}
	}
}
