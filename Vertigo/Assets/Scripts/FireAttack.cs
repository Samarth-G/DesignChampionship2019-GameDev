using UnityEngine;

public class FireAttack : MonoBehaviour {

	public float Speed = 15;
	public int DamageCount = -50;
	public Rigidbody2D Rb;

	void Start () 
	{
		Rb.velocity = transform.right * Speed;
	}
	void OnTriggerEnter2D(Collider2D collider) 
	{
        PlayerMain player = collider.GetComponent<PlayerMain>();
		if (player != null)
		{
			player.HealthChange(DamageCount);
			Destroy(this.gameObject);
		}
	}
	void Update() 
	{
        if (Camera.main.transform.position.y - 8 > this.transform.position.y)
        {
            Destroy(this.gameObject);
        }
	}
}