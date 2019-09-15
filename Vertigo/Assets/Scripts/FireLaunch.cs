using UnityEngine;

public class FireLaunch : MonoBehaviour 
{
	public float timeWait;
	public Transform FirePoint;
	public GameObject FireBall;

	void Start()
	{
		while (true)
		{
            Invoke("Launch", timeWait);
		}
	}
	void Launch()
	{
		Instantiate(FireBall, 
					FirePoint.position, 
					FirePoint.rotation);
	}
}