using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	void Start () {
	
	}
	
	public void IncrementIncline(float incline) {
	
		transform.Rotate(Vector3.forward, -0.5f);
	}
	
	
}
