using UnityEngine;
using System.Collections;

public class HitboxController : MonoBehaviour {
	
	public bool leftDown = false;
	public bool rightDown = false;
	public bool upDown = false;
	public bool downDown = false;
	
	public ArrowSprite activeArrow;
	
	private GameController _gameController;
	
	void Start () {
		_gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		// Left Arrow
		if(Input.GetKeyDown(KeyCode.LeftArrow) && !leftDown) {
			leftDown = true;
		} else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			leftDown = false;	
		}
		
		// Right Arrow
		if(Input.GetKeyDown(KeyCode.RightArrow) && !rightDown) {
			rightDown = true;
		} else if (Input.GetKeyUp(KeyCode.RightArrow)) {
			rightDown = false;	
		}
		
		// Up Arrow
		if(Input.GetKeyDown(KeyCode.UpArrow) && !upDown) {
			upDown = true;
		} else if (Input.GetKeyUp(KeyCode.UpArrow)) {
			upDown = false;	
		}
		
		// Down Arrow
		if(Input.GetKeyDown(KeyCode.DownArrow) && !downDown) {
			downDown = true;
		} else if (Input.GetKeyUp(KeyCode.DownArrow)) {
			downDown = false;	
		}
	
	}
	
	void Update()
	{
		if(leftDown) {
			PressedArrow(ArrowType.LEFT);
		} else if (rightDown) {
			PressedArrow(ArrowType.RIGHT);
		} else if (downDown) {
			PressedArrow(ArrowType.DOWN);
		} else if (upDown) {
			PressedArrow(ArrowType.UP);
		}
	}
	

	private void PressedArrow(ArrowType arrow) {
		
		if(activeArrow) {
			if(upDown && activeArrow.ArrowType == ArrowType.UP) {
				_gameController.Hit();
			} else {
				_gameController.Miss();	
			}
			
			if(downDown && activeArrow.ArrowType == ArrowType.DOWN) {
				_gameController.Hit();
			} else {
				_gameController.Miss();
			}
			
			if(rightDown && activeArrow.ArrowType == ArrowType.RIGHT) {
				_gameController.Hit();
			} else {
				_gameController.Miss();	
			}
			
			if(leftDown && activeArrow.ArrowType == ArrowType.LEFT) {
				_gameController.Hit();
			} else {
				_gameController.Miss();	
			}
			
			activeArrow = null;
		}
		
	}
	
	public void ActivateArrow(GameObject go) {
		activeArrow = go.GetComponent<ArrowSprite>();
	}
	
	public void DeactivateArrow(GameObject go) {
		activeArrow = null;	
	}
}
