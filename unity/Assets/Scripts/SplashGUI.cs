using UnityEngine;
using System.Collections;

public class SplashGUI : MonoBehaviour {
	
	
	public void pressedPlayButton(GameObject go)
	{
		Application.LoadLevel("main");
	}
	
	public void pressedHighscoreButton(GameObject go) {
		Application.LoadLevel("highscores");	
	}
}
