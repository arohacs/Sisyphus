using UnityEngine;
using System.Collections;

public class GutterController : MonoBehaviour {
	
	public GameObject arrowPrefab;
	
	private GameObject _arrowParent;

	private GameObject _hitBox;
	
	void Start ()
	{
		_arrowParent = GameObject.Find("Arrows");
	
		_hitBox = GameObject.Find("HitBox");
		
		SpawnArrow(ArrowType.UP);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void SpawnArrow(ArrowType arrowType)
	{
		GameObject arrow = Instantiate(arrowPrefab, Vector3.zero, Quaternion.identity) as GameObject;
		arrow.transform.parent = _arrowParent.transform;
		arrow.transform.localPosition = Vector3.zero;
		arrow.transform.localScale = new Vector3(39f, 39f, 1.0f);
	
		ArrowSprite sprite = arrow.GetComponent<ArrowSprite>();
		sprite.ArrowType = arrowType;
	}
}
