using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using Signals;

namespace Views
{
	public class PhotoMediator : Mediator
	{
		[Inject] public PhotoView photoView {get;set;}
		[Inject] public PhotoSignal photoSignal {get;set;}

		public override void OnRegister()
		{
			base.OnRegister();
			photoView.photoSignal.AddListener(PhotoClick);
		}

		public override void OnRemove()
		{
			base.OnRemove();
			photoView.photoSignal.RemoveListener(PhotoClick);
		}

		private void PhotoClick()
		{
			photoSignal.Dispatch();
		}
	}
}