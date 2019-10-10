using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using Signals;

namespace Views
{
	public class TriggerHandlerMediator : Mediator
	{
		[Inject] public TriggerHandlerView triggerHandlerView {get;set;}
		[Inject] public FindSignal findSignal {get;set;}
		[Inject] public LostSignal lostSignal {get;set;}

		public override void OnRegister()
		{
			base.OnRegister();
			triggerHandlerView.findSignal.AddListener(FindTarget);
			triggerHandlerView.lostSignal.AddListener(LostTarget);
		}

		public override void OnRemove()
		{
			triggerHandlerView.findSignal.RemoveListener(FindTarget);
			triggerHandlerView.lostSignal.RemoveListener(LostTarget);
		}

		private void FindTarget()
		{
			findSignal.Dispatch(triggerHandlerView.wolf);
		}

		private void LostTarget()
		{
			lostSignal.Dispatch();
		}
	}
}