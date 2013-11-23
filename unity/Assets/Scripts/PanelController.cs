using UnityEngine;
using System.Collections;

public class PanelController : MonoBehaviour {
	
	public GameObject nodePrefab;
	public Transform gutter;
	public GameObject highlight;
	
	private Vector3 _spawn;
	private Vector3 _destination;
	
	void Start () 
	{
		gutter = GameObject.FindGameObjectWithTag("Gutter").transform;
		
		_spawn = new Vector3(gutter.localPosition.x + (gutter.localScale.x / 2), gutter.localPosition.y, gutter.localPosition.z);
		_destination = gutter.localPosition;
		
		GameObject go = Instantiate(nodePrefab, Vector3.zero, Quaternion.identity) as GameObject;
		go.transform.parent = this.gameObject.transform;
		go.transform.localPosition = _spawn;
		go.transform.localScale = new Vector3(30, 29, 1);
		//go.transform.localScale = Vector3.one;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
