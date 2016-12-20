using UnityEngine;
using System.Collections;

public class spectrum : MonoBehaviour
{

	public GameObject prefab;
	public int numberOfObjects = 20;
	public float radius = 5f;
	public GameObject[] cubes;
	//public AudioSource src;
	//public float maxTime;
	//public float currentTime;
	//public Material mat;

	//public float r;
	//public float g;
	//public float b;

	// Use this for initialization
	void Start ()
	{

		//r = mat.color.r;z
		//g = mat.color.g;
		//b = mat.color.b;

		for (int i = 0; i < numberOfObjects; i++) {
			float angle = i * Mathf.Deg2Rad * 200 / numberOfObjects;
			Vector3 pos = new Vector3 (Mathf.Cos (angle), 0, Mathf.Sin (angle)) * radius;
			Instantiate (prefab, pos, Quaternion.identity);
		}
		cubes = GameObject.FindGameObjectsWithTag ("Cubes");

		//	maxTime = src.clip.length;

	}
	
	// Update is called once per frame
	void Update ()
	{
		float[] spectrum = new float[1024];
		AudioListener.GetSpectrumData (spectrum, 0, FFTWindow.Hamming);
		for (int i = 0; i < numberOfObjects; i++) {
			Vector3 previousScale = cubes [i].transform.localScale;
			previousScale.y = Mathf.Lerp (previousScale.y, spectrum [i] * 70, Time.deltaTime * 30);
			cubes [i].transform.localScale = previousScale;
		
		}
	}

	//void onGUI() {
	//r = GUI.HorizontalSlider (new Rect(10,10, Screen.width - 40, 100), r, 0.0f, 1.0f);
	//g = GUI.HorizontalSlider

	


}
