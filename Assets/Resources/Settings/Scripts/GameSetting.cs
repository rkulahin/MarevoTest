using UnityEngine;

[CreateAssetMenu(fileName = "GameSetting", menuName = "GameSetting", order = 1)]
public class GameSetting : ScriptableObject
{
	[SerializeField, Range(1,30)] private int _RunTime;

	public int RunTime => _RunTime;
}