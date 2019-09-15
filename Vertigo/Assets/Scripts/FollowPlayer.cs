using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
	public Transform Player;
    private Vector3 CurrentVelocity;
	
	public float smoothSpeed = 0.4f;

	void LateUpdate() 
	{
		if (Player.position.y > transform.position.y)
		{
			Vector3 newPosition = new Vector3(transform.position.x, 
												Player.position.y, 
												transform.position.z);

			transform.position = Vector3.SmoothDamp(transform.position, 
													newPosition, 
													ref CurrentVelocity, 
													smoothSpeed * Time.deltaTime);
		}
	}
}