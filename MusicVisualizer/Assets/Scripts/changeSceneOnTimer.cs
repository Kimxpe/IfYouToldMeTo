using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeSceneOnTimer : MonoBehaviour {
	public float timer = 10;

	void Start () {
	}
	

	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			SceneManager.LoadScene ("MusicSpectrum 9");
		}
	}


}
