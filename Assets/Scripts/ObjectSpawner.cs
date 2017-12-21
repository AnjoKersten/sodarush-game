using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public Transform[] buildings;
	public Transform player1Transform;
	public Transform player2Transform;

	public Vector2 player1Pos;
	public Vector2 player2Pos;

	public int currentBuilding;

	public bool allowSpawn;

	private float spawnPos;

	private int randomBuilding;
	private float randomHeight;

	float spawnTimer = 0;

	private bool buildingSpawned;

	void Start () {
		
		currentBuilding = 0;
		allowSpawn = true;

	}

	void Update () {

		spawnPos = Random.Range(2.1f, 2.9f);

		randomBuilding = Random.Range (0, 9);
		randomHeight = Random.Range (-7f, -2f);

		if (Time.timeScale > 0) {
			spawnTimer++;
		}


		if (spawnTimer * Time.deltaTime >= spawnPos) {
			spawnNewBuilding01 ();
			spawnTimer = 0f;
		}
			
	}

	void spawnNewBuilding01(){
		Instantiate (buildings [randomBuilding], new Vector2 (this.transform.position.x, randomHeight + this.transform.position.y), transform.rotation);

	}
}
