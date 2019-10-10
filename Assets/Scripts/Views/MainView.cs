using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using Interfaces;

namespace Views
{
	public class MainView : View, IHidebleView
	{
		public void Hide(bool hide)
		{
			gameObject.SetActive(!hide);
		}
	}
}
