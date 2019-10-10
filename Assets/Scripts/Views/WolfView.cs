using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.signal.impl;
using strange.extensions.signal.api;

namespace Views
{
public class WolfView : MainView
	{
		public Animator animator;
		public Signal ActiveSignal = new Signal();

		protected override void Start()
		{
			base.Start();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();

		}

		private void OnMouseUp() 
		{
			ActiveSignal.Dispatch();
		}
	}
}
