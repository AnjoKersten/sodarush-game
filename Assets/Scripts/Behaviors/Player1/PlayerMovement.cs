using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	void Update () {
		
			this.transform.position = new Vector2 (this.transform.position.x - (50 * Time.deltaTime), this.transform.position.y);
	}
}
