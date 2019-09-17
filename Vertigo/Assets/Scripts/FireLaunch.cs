using UnityEngine;

public class FireLaunch : MonoBehaviour 
{
	public float timeWait;
	public Transform FirePoint;
	public GameObject FireBall;

	void Start()
	{
		Invoke("Launch", 5);
	}
	void Launch()
	{
		Instantiate(FireBall, 
					FirePoint.position, 
					FirePoint.rotation);
	}
}