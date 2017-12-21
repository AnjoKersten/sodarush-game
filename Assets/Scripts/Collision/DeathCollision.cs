using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	void Start () {
	
	}

	void Update () {


		
	}

	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject == player1) {

			Application.LoadLevel(2);
		}

		if (collision.gameObject == player2) {

			Application.LoadLevel(3);
		}

		/*
		if (collision.gameObject.tag == "Player") {

			Application.LoadLevel(2);
		}
		*/
	}
}
