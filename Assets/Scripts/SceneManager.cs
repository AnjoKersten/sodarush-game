using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

	public GameObject mainScreen;
	public GameObject creditScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void LoadCredits() {
		mainScreen.SetActive (false);
		creditScreen.SetActive (true);
	}

	public void LoadMain() {
		creditScreen.SetActive (false);
		mainScreen.SetActive (true);
	}


	public void LoadMainMenu() {
		Application.LoadLevel (0);
	}

	public void LoadGame() {
		Application.LoadLevel (1);
		Time.timeScale = 1.0f;
	}

	public void QuitGame() {
		Application.Quit();
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}
