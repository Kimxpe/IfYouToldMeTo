using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public float speed = 20;
	private bool canFire = true;
	public float rateOfFire = 2f;


	public GameObject[] enemies;
	private int theScore;
	public Text scoreText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			canFire = false;
			StartCoroutine ("reload");
			Rigidbody instantiatedBullet = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
			instantiatedBullet.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
		}
	}

	IEnumerator reload () {
		yield return new WaitForSeconds (rateOfFire);
		canFire = true;
	}
	
	
	
	

}
