using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.signal.impl;
using strange.extensions.signal.api;

namespace Views
{
	public class PhotoView : MainView
	{
		[SerializeField] private Button _photoButton;
		public Signal photoSignal = new Signal();

		protected override void Start()
		{
			base.Start();
			_photoButton.onClick.AddListener(PhotoClick);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();

		}

		private void PhotoClick()
		{
			photoSignal.Dispatch();
		}
	}
}
