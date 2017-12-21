using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseMenu;

	public ObjectSpawner oSpawner;

	private bool gamePaused;

	// Use this for initialization
	void Start () {

		gamePaused = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("escape")) {
			if (pauseMenu.active == false) {
				//Debug.Log ("PAUSE GAME");
				pauseGame ();
				pauseMenu.SetActive (true);
				oSpawner.allowSpawn = false;
			} 
			else if (pauseMenu.active == true) {
				//Debug.Log ("UNPAUSE GAME");
				unpauseGame ();
				pauseMenu.SetActive (false);
				oSpawner.allowSpawn = true;
			}
		} 
	}

	public void pauseGame(){

		Time.timeScale = 0.0f;

	}

	public void unpauseGame(){

		Time.timeScale = 1.0f;
		if (pauseMenu.active == true) {
			pauseMenu.SetActive (false);
		}

	}
}
