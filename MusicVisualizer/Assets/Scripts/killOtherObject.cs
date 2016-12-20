using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {

	//	public GameObject bullet;
	//	public GameObject enemy;
	// Update is called once per frame

	//private scoreTracker sT;

	void Start () {

		//sT.GetComponent<scoreTracker> ();
	}

	void OnCollisionEnter (Collision otherCollider) {
		if (otherCollider.gameObject.CompareTag ("bullets")) {

			//sT.score += 4;
			//GameObject scoreH = GameObject.Find ("Score");
			//scoreH.GetComponent<scoreTracker> ().addScore (4);


			Destroy (gameObject);
			Destroy (otherCollider.gameObject);

			//sT.score += 4;

		}

	}

}