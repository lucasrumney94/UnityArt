using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNodes : MonoBehaviour {
	
	public float speed = 1.0f;

	public bool matchBackgroundColor = false;
	public bool speedIsSin = false;
	public float frequency = 5.0f;
	public float SinMagnitude = 5.0f;



	private List<GameObject> ZoomObjects;


	private int currentZoomObjectIndex = 0;
	
	private float t = 0.0f;
	private Transform randomlyChosenNode;
	private Transform lastRandomlyChosenNode;

	private bool doOnceFlag = true;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (speedIsSin)
		{
			speed = SinMagnitude * Mathf.Abs(Mathf.Sin(frequency*Time.time));
		}
		if (doOnceFlag)
		{
			ZoomObjects = GameObject.FindGameObjectWithTag("Chain").GetComponent<SpawnLP>().ZoomObjects;
			randomlyChosenNode = ZoomObjects[0].transform.GetChild(Random.Range(0, ZoomObjects[0].transform.childCount));

			doOnceFlag = false;
		}

		t += speed*Time.deltaTime;
		if (t > 1.0f)
		{
			lastRandomlyChosenNode = randomlyChosenNode;
			t -= 1.0f;
			currentZoomObjectIndex += 1;
			randomlyChosenNode = ZoomObjects[currentZoomObjectIndex].transform.GetChild(Random.Range(0, ZoomObjects[0].transform.childCount-1));
			if (matchBackgroundColor)
			{
				this.GetComponent<Camera>().backgroundColor = ZoomObjects[currentZoomObjectIndex].GetComponent<SpriteRenderer>().color;
			}
		}
		if( currentZoomObjectIndex > ZoomObjects.Count-2)
		{
			currentZoomObjectIndex = 1;
			
		}

		//This will hop to a beat
		//transform.position = Vector3.Lerp(transform.position, randomlyChosenNode.position, t);

		//This is smooth
		if (currentZoomObjectIndex>0 )
		{
			transform.position = Vector3.Lerp(lastRandomlyChosenNode.position, randomlyChosenNode.position, t);
		}


	}
}
