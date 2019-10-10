using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using Signals;

namespace Views
{
	public class ShareMediator : Mediator
	{
		[Inject] public ShareView shareView {get;set;}
		[Inject] public ShareSignal shareSignal {get;set;}
		[Inject] public BackSignal backSignal {get;set;}

		public override void OnRegister()
		{
			base.OnRegister();
			shareView.backSignal.AddListener(ClickBack);
			shareView.shareSignal.AddListener(ClickShare);
		}

		public override void OnRemove()
		{
			base.OnRemove();
			shareView.backSignal.RemoveListener(ClickBack);
			shareView.shareSignal.RemoveListener(ClickShare);
		}

		private void ClickBack()
		{
			backSignal.Dispatch();
		}

		private void ClickShare()
		{
			shareSignal.Dispatch();
		}
	}
}