using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour 
{	
	public bool ended = false;

	public void EndGame()
	{
		if (ended == false)
		{	
			ended = true;
			Debug.Log("OVER");
			Invoke("Restart", 1);
		}
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
