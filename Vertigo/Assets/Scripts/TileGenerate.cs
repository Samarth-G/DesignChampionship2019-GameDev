using UnityEngine;

public class TileGenerate : MonoBehaviour 
{
	public GameObject NormalTile;
	public GameObject AirTile;
	public GameObject SandTile;
	public GameObject WaterDroplet;
	
	public int NumberOfTiles;
	public float Width;
	public float minGap;
	public float maxGap;

	void Start () 
	{
		Vector3 SpawnPoint = new Vector3();
        Vector3 DropPoint = new Vector3();
        SpawnPoint.y = -4;

		for (int i = 0; i < NumberOfTiles; i++)
		{
			SpawnPoint.x = Random.Range(-Width, Width);
			int tileChoose = Random.Range(0, 100);

			if (tileChoose <= 90)
			{
                SpawnPoint.y += Random.Range(minGap, maxGap);
				if (tileChoose <= 50)
				{
                    DropPoint = SpawnPoint;
					DropPoint.y += 0.35f;
					Instantiate(WaterDroplet, DropPoint, Quaternion.identity);
				}
				Instantiate(NormalTile, SpawnPoint, Quaternion.identity);
			}
			else if (tileChoose <= 97)
			{
                SpawnPoint.y += Random.Range(minGap, maxGap);
                Instantiate(AirTile, SpawnPoint, Quaternion.identity);
			}
			else
			{
                SpawnPoint.y += Random.Range(0.5f, 0.9f);
				Instantiate(SandTile, SpawnPoint, Quaternion.identity);
			}
		}
	}
}