using UnityEngine;
using System.Collections;

public class enemy2 : MonoBehaviour {

	public float speed;
	private Transform player;

	void Start() {
		//assign the player variable dynamically
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	

	void FixedUpdate () {
		// Arc Tangent gets an angle betweeen two points
		// rotate the enemy based on the angle between two points
		if (player != null) {
			float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
	
			transform.eulerAngles = new Vector3 (0, 0, z);
		}
		GetComponent<Rigidbody> ().AddForce (transform.up * speed);

	
	}
}
