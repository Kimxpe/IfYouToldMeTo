using UnityEngine;
using System.Collections;

public class destroyAfterTime : MonoBehaviour {

	// Use this for initialization

	public float lifetime = 2.0f;
	void Awake()
	{
			Destroy(gameObject, lifetime);
	}
	
}
