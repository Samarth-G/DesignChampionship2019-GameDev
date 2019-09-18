using UnityEngine;

public class FireLaunch : MonoBehaviour 
{
        public float timeWait;
	public GameObject FireBall;

    public Transform FirePoint1;
    public Transform FirePoint2;
    public Transform FirePoint3;
    public Transform FirePoint4;

    Vector3 Pos = new Vector3();

    void Start()
	{
        InvokeRepeating("Launch", timeWait, timeWait);
	}
	void Launch()
	{
	        int choose = Random.Range(0, 4);

		if (choose == 0)
		{
                Pos = FirePoint1.position;
                Pos.z = 0;
                Instantiate(FireBall,
                    Pos,
                    FirePoint1.rotation);
		}
		else if (choose == 1)
		{
                Pos = FirePoint2.position;
                Pos.z = 0;
                Instantiate(FireBall,
                    Pos,
                    FirePoint2.rotation);
		}
                else if (choose == 2)
                {
                Pos = FirePoint3.position;
                Pos.z = 0;
                Instantiate(FireBall,
                        Pos,
                        FirePoint3.rotation);
                }
                else
                {
                Pos = FirePoint4.position;
                Pos.z = 0;
                Instantiate(FireBall,
                        Pos,
                        FirePoint4.rotation);
                }
	}
}