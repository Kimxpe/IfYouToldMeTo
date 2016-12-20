using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textController : MonoBehaviour {

	public Text instructionText;

	void Start()
	{
		instructionText.text = "DEFEND YOURSELF";
		Time.timeScale = 1;
	}

	void Update () 
	{
		if(Input.anyKeyDown)
		{
			//Time.timeScale = 1;
			Destroy(gameObject);
		}
	}
}
