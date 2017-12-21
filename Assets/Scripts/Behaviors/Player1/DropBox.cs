using UnityEngine;
using System.Collections;

public class DropBox : MonoBehaviour {

	public Transform crate;
	private float counter;

	void Start() {
		counter = 0;
	}

	void Update () {

		counter++;

		if(Input.GetKeyDown(KeyCode.LeftControl) && counter > 100) {
			SpawnCrate();
			counter = 0;
		}
	}

	void SpawnCrate() {
		Instantiate (crate, new Vector2 (this.transform.position.x, this.transform.position.y), transform.rotation);
	}
}
