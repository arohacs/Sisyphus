using UnityEngine;
using System.Collections;

public class HighscoreController : MonoBehaviour { 
	
	// these are the 10 UILabels on the scene
	public UILabel highscoreName0;
	public UILabel highscoreScore0;
	
	public UILabel highscoreName1;
	public UILabel highscoreScore1;
	
	public UILabel highscoreName2;
	public UILabel highscoreScore2;
	
	public UILabel highscoreName3;
	public UILabel highscoreScore3;
	
	public UILabel highscoreName4;
	public UILabel highscoreScore4;
	
	private string[] _highscores;
	void Start()
	{
		_highscores = HighScores();
		DisplayHighScores();
	}
	
	// Highscores is stored as a string with '|' delimiter
	// ex:  "Stu B-133ft | Adam R-52ft | Monty-50ft | Kate-25ft"
	private string[] HighScores()
	{
		if (PlayerPrefs.HasKey("highscores")) {
			string scores = PlayerPrefs.GetString("highscores");
			return scores.Split("|"[0]);
		}
           // return PlayerPrefs.GetString("highscores").Split("-");
        return new string[0];
	}
	
	// Returns the name and score as an array of 2 elements
	// ex: 
	//     _highscores = GetHighScores();  
	//		 _highscores[0] = "Stu B-133ft"
	//   calling PlayerNameAndScore(_highscores[0]) 
	//     return value is an array: [0] = Stu B
	//                               [1] = 133ft
	private string[] GetPlayerNameAndScore(string player) {
		string[] retVal = player.Split("-"[0]);
		return retVal;
	}
	
	private void DisplayHighScores()
	{
		string[] score0 = GetPlayerNameAndScore(_highscores[0]);
		highscoreName0.text = score0[0];
		highscoreScore0.text = score0[1];

		string[] score1 = GetPlayerNameAndScore(_highscores[0]);
		highscoreName1.text = score1[0];
		highscoreScore1.text = score1[1];

		string[] score2 = GetPlayerNameAndScore(_highscores[0]);
		highscoreName2.text = score2[0];
		highscoreScore2.text = score2[1];

		string[] score3 = GetPlayerNameAndScore(_highscores[0]);
		highscoreName3.text = score3[0];
		highscoreScore3.text = score3[1];

		string[] score4 = GetPlayerNameAndScore(_highscores[0]);
		highscoreName4.text = score4[0];
		highscoreScore4.text = score4[1];

		// ...
		// ...
		// ...
	}
	public void pressedBackButton(GameObject go)
	{
		Application.LoadLevel("splash");	
	}
}
