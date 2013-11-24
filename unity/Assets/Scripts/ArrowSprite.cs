using UnityEngine;
using System.Collections;


public enum ArrowType
{
	UNDEFINED,
	LEFT,
	RIGHT,
	UP,
	DOWN,
}
public class ArrowSprite : MonoBehaviour {
	
	public float moveSpeed = 0.4f;
	private bool isAlive;
	private UISprite _sprite;
	
	private HitboxController _hitboxController;
	private GameController _gameController;
	private ArrowType _arrowType = ArrowType.UNDEFINED;
	
	void Awake () {
		_sprite = GetComponent<UISprite>();
		_hitboxController = GameObject.FindGameObjectWithTag("HitBox").GetComponent<HitboxController>();
		_gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		isAlive = true;
	}
	
	
	public ArrowType ArrowType
	{
		get {
			return _arrowType;
		}
		set {
			_arrowType = value;
			_sprite.spriteName = getArrowSpriteName(_arrowType);
		}
	}
	
	private string getArrowSpriteName(ArrowType arrowType)
	{
		if(arrowType == ArrowType.LEFT){
			return "arrow_left";	
		} else if (arrowType == ArrowType.RIGHT) {
			return "arrow_right";	
		} else if (arrowType == ArrowType.UP) {
			return "arrow_up";	
		} else if (arrowType == ArrowType.DOWN) {
			return "arrow_down";
		}
		
		return "space";
		
	}
	
	private void Kill()
	{
		isAlive = false;
		
		
		Destroy(gameObject);
	}
	
	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Deadzone") {
			_hitboxController.DeactivateArrow(gameObject);
			_gameController.Miss();
			Kill();	
		} else if (col.gameObject.tag == "HitBox") {
			_hitboxController.ActivateArrow(gameObject);
		} 
	}

	void LateUpdate()
	{
		if(isAlive) {
			transform.position += Vector3.left * Time.deltaTime * moveSpeed;
		} 
			
	}
	

}
