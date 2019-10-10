using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using Signals;

namespace Views
{
	public class WolfMediator : Mediator
	{
		[Inject] public WolfView wolfView {get;set;}
		[Inject] public ActiveFigureSignal activeFigureSignal {get;set;}
		public override void OnRegister()
		{
			base.OnRegister();
			wolfView.ActiveSignal.AddListener(MouseUp);
		}

		public override void OnRemove()
		{
			base.OnRemove();
			wolfView.ActiveSignal.RemoveListener(MouseUp);
		}

		private void MouseUp()
		{
			activeFigureSignal.Dispatch(wolfView.animator);
		}
	}
}
