using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMain : MonoBehaviour 
{
    float move = 0f;
	public float moveSpeed = 10f;
	public int health = 100;
	
	Rigidbody2D Rb;

	void Start () 
	{
		Rb = GetComponent<Rigidbody2D>();
	}
	void Update () 
	{
		move = Input.GetAxis("Horizontal");
        if (Camera.main.transform.position.y - 8 > this.transform.position.y)
        {
            Dead();
        }
	}
	void FixedUpdate() 
	{
		Vector2 velocity = Rb.velocity;
		velocity.x = move * moveSpeed;
		Rb.velocity = velocity;
	}
	public void HealthChange(int damage)
	{
		health = health + damage;
		if (health <= 0)
		{
			Dead();
		}
		else if (health > 100)
		{
			health = 100;
		}
	}
	void Dead()
	{	
		FindObjectOfType<Manager>().EndGame();
	}
}
