using UnityEngine;
using System.Collections;

public class SplashGUI : MonoBehaviour {
	
	
	public string title = "Sisyphus";
	public float playButtonWidth = 300.0f;
	public float playButtonHeight = 100.0f;
	
	// Use this for gui display and interaction
	void OnGUI()
	{
		// Play button loads 'main' scene
		// for now just position in the middle of the screen
		if(GUI.Button(new Rect(Screen.width / 2 - playButtonWidth / 2, Screen.height / 2 - playButtonHeight / 2, playButtonWidth, playButtonHeight), "Play")) {
			Application.LoadLevel("main");
		}
	}
}
