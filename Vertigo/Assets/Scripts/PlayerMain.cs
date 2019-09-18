777776using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMain : MonoBehaviour 
{
    float move = 0f;
	public float moveSpeed = 10f;
	public Slider HealthBar;
	
	Rigidbody2D Rb;

	public void JumpAnimation()
	{
		this.transform.localScale = new Vector3(0.65f, 0.4f, 1f);
		Invoke("JumpOver", 0.2f);
	}
	void JumpOver()
	{
        this.transform.localScale = new Vector3(0.65f, 0.555f, 1f);
    }
	void Start () 
	{
		Rb = GetComponent<Rigidbody2D>();
	}
	void Update () 
	{
		move = Input.GetAxis("Horizontal");
        if (Camera.main.transform.position.y - 12 > this.transform.position.y)
        {
            HealthBar.value = 0;
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
		Debug.Log(HealthBar.value);
        HealthBar.value += damage;
		if (HealthBar.value < 0)
		{
            HealthBar.value = 0;
		}
		if (HealthBar.value == 0)
		{
			Rb.Sleep();
			Dead();
		}
		if (HealthBar.value > 100)
		{
            HealthBar.value = 100;
		}	
	}
	void Dead()
	{
		Rb.Sleep();
		FindObjectOfType<Manager>().EndGame();
	}
}
