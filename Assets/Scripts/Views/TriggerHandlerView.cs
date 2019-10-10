using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using Signals;
using strange.extensions.signal.impl;

namespace Views
{
	public class TriggerHandlerView : MainView, ITrackableEventHandler
	{
		private TrackableBehaviour mTrackableBehaviour;
		public GameObject wolf;
		public Signal findSignal = new Signal();
		public Signal lostSignal = new Signal();

		protected override void Start()
		{
			base.Start();
 			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}
		}
		
		protected override void OnDestroy()
		{
			base.OnDestroy();

		}

		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				Debug.Log("find");
				findSignal.Dispatch();
			}
			else
			{
				Debug.Log("lost");
				lostSignal.Dispatch();
			}
		}

	}
}