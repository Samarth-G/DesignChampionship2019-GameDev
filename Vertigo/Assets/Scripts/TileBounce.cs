using UnityEngine;

public class TileBounce : MonoBehaviour {

	public float Jump = 10f;

	void OnCollisionEnter2D(Collision2D collision) 
	{
        Rigidbody2D Rb = collision.collider.GetComponent<Rigidbody2D>();

        if (Rb.gravityScale == 1)
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                FindObjectOfType<PlayerMain>().JumpAnimation();
                Vector2 velocity = Rb.velocity;
                velocity.y = Jump;
                Rb.velocity = velocity;
            }
        }
	}
    void Update() 
    {
        if (Camera.main.transform.position.y - 5.12 > this.transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}