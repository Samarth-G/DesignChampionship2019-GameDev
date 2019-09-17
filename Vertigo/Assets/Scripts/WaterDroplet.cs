using UnityEngine;

public class WaterDroplet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerMain player = collider.GetComponent<PlayerMain>();
        if (player != null)
        {
            player.HealthChange(25);
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (Camera.main.transform.position.y - 5.4 > this.transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}