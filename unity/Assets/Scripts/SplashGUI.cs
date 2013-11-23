using UnityEngine;
using System.Collections;

public class SplashGUI : MonoBehaviour {
	
	
	public void pressedPlayButton(GameObject go)
	{
		Debug.Log("pressedPlayButton");	
		Application.LoadLevel("main");
	}
}
