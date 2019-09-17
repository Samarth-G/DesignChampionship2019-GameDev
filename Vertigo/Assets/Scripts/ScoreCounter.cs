using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour 
{
	public Text scoreBoard;

	void Update () 
	{
		scoreBoard.text = (Camera.main.transform.position.y - 0.03).ToString("0");
	}
}