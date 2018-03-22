using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLP : MonoBehaviour {

	public GameObject ZoomObject;
	public int numberOfZooms = 100;
	public float distanceBetweenZoomObjects = 10.0f;


	public bool randomColor = false;

	[HideInInspector]
	public List<GameObject> ZoomObjects = new List<GameObject>();
	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < numberOfZooms; i++)
		{
			GameObject go = Instantiate(ZoomObject, i*distanceBetweenZoomObjects*Vector3.forward, Quaternion.identity);
			if (randomColor)
			{
				go.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
			}
			ZoomObjects.Add(go);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
