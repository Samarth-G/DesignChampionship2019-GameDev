using UnityEngine;

public class TileBounce : MonoBehaviour {

	public float Jump = 10f;
	void OnCollisionEnter2D(Collision2D collision) 
	{
		if (collision.relativeVelocity.y <= 0f)
		{
            Rigidbody2D Rb = collision.collider.GetComponent<Rigidbody2D>();
            if (Rb != null)
            {
                Vector2 velocity = Rb.velocity;
                velocity.y = Jump;
                Rb.velocity = velocity;
            }
		}
	}
}