using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{	
	bool ended = false;

	public void EndGame()
	{
		if (ended == false)
		{	
			ended = true;
			Debug.Log("OVER");
		}
	}
	void Restart()
	{
		
	}
}
