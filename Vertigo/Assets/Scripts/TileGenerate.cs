using UnityEngine;

public class TileGenerate : MonoBehaviour 
{
	public GameObject NormalTile;
	public GameObject AirTile;
	public GameObject SandTile;
	
	public int NumberOfTiles;
	public float Width;
	public float minGap;
	public float maxGap;

	void Start () 
	{
		Vector3 SpawnPoint = new Vector3();
        SpawnPoint.y = - 5;

		for (int i = 0; i < NumberOfTiles; i++)
		{
			SpawnPoint.y += Random.Range(minGap, maxGap);
			SpawnPoint.x = Random.Range(-Width, Width);

			int tileChoose = Random.Range(0, 100);

			if (tileChoose <= 90)
			{
				Instantiate(NormalTile, SpawnPoint, Quaternion.identity);
			}
			else if (tileChoose <= 97)
			{
                Instantiate(AirTile, SpawnPoint, Quaternion.identity);
			}
			else
			{
				Instantiate(SandTile, SpawnPoint, Quaternion.identity);
			}
		}
	}
	void Update () 
	{
		
	}
}
