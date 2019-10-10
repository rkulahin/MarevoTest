using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackInfoButton : MonoBehaviour
{
	[SerializeField] Button _backButton;
    // Start is called before the first frame update
    private void Awake() 
	{
		_backButton.onClick.AddListener(HideInfoPanel);
	}

	private void HideInfoPanel()
	{
			gameObject.SetActive(false);
	}
}
