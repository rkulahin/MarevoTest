using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using strange.extensions.signal.impl;

namespace Views
{
	public class ShareView : MainView
	{
		[SerializeField] private Button _backButton;
		[SerializeField] private Button _shareButton;
		public Signal shareSignal = new Signal();
		public Signal backSignal = new Signal();
		protected override void Start()
		{
			base.Start();
			_backButton.onClick.AddListener(ClickBack);
			_shareButton.onClick.AddListener(ClickShare);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			_backButton.onClick.RemoveListener(ClickBack);
			_shareButton.onClick.RemoveListener(ClickShare);
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