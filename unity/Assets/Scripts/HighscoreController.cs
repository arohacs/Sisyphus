using UnityEngine;
using System.Collections;

public class HighscoreController : MonoBehaviour {

	public void pressedBackButton(GameObject go)
	{
		Application.LoadLevel("splash");	
	}
}
