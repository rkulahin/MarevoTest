using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using strange.extensions.command.impl;
using Signals;

namespace Commands
{
	public class ActiveFigureCommand : Command
	{
		[Inject] public SoundManager soundManager {get;set;}
		[Inject] public Animator animator {get;set;}
		[Inject] public DeactivateFigureSignal deactivateFigureSignal {get;set;}

		private Timer timerTime;
		public override void Execute()
		{
			Debug.Log("Activate Figure");
			soundManager.audioSource.clip = soundManager.ActiveAudio;
			if (!soundManager.audioSource.isPlaying)
			{
				soundManager.audioSource.Play();
			}
			animator.SetBool("Run", true);
			 timerTime = new Timer(Callback, null, 15000, Timeout.Infinite);
		}

		private void Callback(object state)
		{
			deactivateFigureSignal.Dispatch(animator);
		}
	}
}
