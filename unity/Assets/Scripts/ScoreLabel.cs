using UnityEngine;
using System.Collections;

public class ScoreLabel : MonoBehaviour {

	public int score = 0;
	void Start () 
	{
		score = 0;
	}
	
	public void IncrementScore(int n) {
		score += n;
		
		GUIText guiText = GetComponent<GUIText>();
		guiText.text = score +" ft.";
	}
}
