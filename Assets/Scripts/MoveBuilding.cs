using UnityEngine;
using System.Collections;

public class MoveBuilding : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector2 (this.transform.position.x - (50 * Time.deltaTime), this.transform.position.y);
	}
}
