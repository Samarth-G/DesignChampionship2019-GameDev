using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour 
{
    float move = 0f;
	public float moveSpeed = 10f;
	Rigidbody2D Rb;
	void Start () 
	{
		Rb = GetComponent<Rigidbody2D>();
	}
	void Update () 
	{
		move = Input.GetAxis("Horizontal");
	}
	void FixedUpdate() 
	{
		Vector2 velocity = Rb.velocity;
		velocity.x = move * moveSpeed;
		Rb.velocity = velocity;
	}
}
