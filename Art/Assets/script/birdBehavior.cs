using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdBehavior : MonoBehaviour {

	public GameObject streak;
	private Vector3 newPosition;
	private Vector3 wiggle;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(Vector3.zero);
		newPosition = new Vector3(Mathf.Sin(Time.time),Mathf.Cos(Time.time), 0.0f);
		newPosition *= 5.0f;
		wiggle = new Vector3(2.0f*Mathf.Sin(4*Time.deltaTime),2.0f*Mathf.Cos(4*Time.deltaTime),0.0f);
		newPosition += new Vector3(wiggle.x*transform.right.x,wiggle.y*transform.right.y,0.0f);
		newPosition += new Vector3(wiggle.x*transform.up.x,wiggle.y*transform.up.y,0.0f);
		transform.position = newPosition;


		if (Random.Range(1,100)%50 == 0)
		{
			GameObject.Instantiate(streak, transform.position, Quaternion.identity);
		}

	}
}
