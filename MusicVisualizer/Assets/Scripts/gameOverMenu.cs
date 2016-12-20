using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverMenu : MonoBehaviour {


	public void StartLevel (string scene) {
		SceneManager.LoadScene (scene); 
	}

	public void MainMenu (string scene) {
		SceneManager.LoadScene (scene);
	}

	public void ExitGame () {
		Application.Quit();
	}
}
