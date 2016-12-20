using UnityEngine;
using System.Collections;

public class SpawnKill : MonoBehaviour {

	public GameObject enemy1;

	void Start (){
		InvokeRepeating("SpawnEnemy", 5f, 4f);
	}

	void SpawnEnemy() {
		Instantiate (enemy1, transform.position, transform.rotation);
	}

}

