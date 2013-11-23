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
	
	public float moveSpeed = 10.0f;
	private UISprite _sprite;
	
	private ArrowType _arrowType = ArrowType.UNDEFINED;
	
	void Awake () {
		_sprite = GetComponent<UISprite>();
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
	
	void Update()
	{
	

	}
	

}
