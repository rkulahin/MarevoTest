using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using strange.extensions.signal.api;
using strange.extensions.signal.impl;
using Views;

namespace Signals
{
	public class StartSignal : Signal {}
	public class MenuSignal : Signal<GameObject> {}
	public class MenuHideSignal : Signal<GameObject> {}
	public class MenuSoundSignal : Signal {}
	public class MenuInfoSignal : Signal<GameObject> {}
	public class MenuMailSignal : Signal<GameObject, Button> {}
	public class FindSignal : Signal<GameObject> {}
	public class LostSignal : Signal {}
	public class PhotoSignal : Signal {}
	public class ShareSignal : Signal {}
	public class BackSignal : Signal {}
	public class ActiveFigureSignal : Signal<Animator> {}
	public class DeactivateFigureSignal : Signal<Animator> {}
}