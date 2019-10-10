using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using strange.extensions.context.impl;
public class Bootstrap : ContextView
{
	[SerializeField] private UIManager _uiManager;
	[SerializeField] private SoundManager _soundManager;
	private MainContext _context;
	
    private void Awake()
	{
		_context = new MainContext(_uiManager, _soundManager, this);
		    if (!_soundManager.audioSource.isPlaying)
    {
		_soundManager.audioSource.Play();
    }
		_context.Start();
		_context.Launch();
	}
}
