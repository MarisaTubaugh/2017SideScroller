using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {
	private int _Lives = 3;
	public int points;

	public Text livesValue;


	// Use this for initialization
	public void SetLives(int newValue) {
		_Lives = newValue;
		Debug.Log("Lives now equals: " + _Lives);
		livesValue.text = _Lives.ToString();
	}
	public int GetLives()
	{
		return _Lives;
	}
}
