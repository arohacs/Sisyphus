using UnityEngine;
using System.Collections;

public class GutterController : MonoBehaviour {
	
	public GameObject arrowPrefab;
	public bool isPlaying;
	
	public float nextSpawn;
	public float spawnDelay = 1.0f;
	
	private GameObject _arrowParent;

	private GameObject _hitBox;
	
	void Start ()
	{
		isPlaying = false;
		
		_arrowParent = GameObject.Find("Arrows");
	
		_hitBox = GameObject.Find("HitBox");
	}
	
	public void Play()
	{
		SpawnArrow(ArrowType.LEFT);
		spawnDelay = 1.0f;
		
		nextSpawn = Time.fixedTime + spawnDelay;
		
		isPlaying = true;
	}
	
	public void Pause()
	{
		isPlaying = false;
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
	
	private ArrowType GetRandomArrow()
	{
		int arrow = Random.Range(0,4);
		
		ArrowType arrowType = ArrowType.UNDEFINED;
		
		if(arrow == 1) {
			arrowType = ArrowType.DOWN;	
		} else if (arrow == 2) {
			arrowType = ArrowType.UP;	
		}  else if (arrow == 3) {
			arrowType = ArrowType.LEFT;	
		} else if (arrow == 4) {
			arrowType = ArrowType.RIGHT;	
		}
		
		return arrowType;
		
	}
	void Update ()
	{
		if(isPlaying)
		{
			if(Time.fixedTime > nextSpawn) {
				
				ArrowType arrowType = GetRandomArrow();
			
				if(arrowType != ArrowType.UNDEFINED) {
					SpawnArrow(arrowType);
				}
				
				nextSpawn = Time.fixedTime + spawnDelay;
			}
		}
	}
}
