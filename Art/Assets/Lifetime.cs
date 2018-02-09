using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {
	public float lifetimeInSeconds;

	private float initTime;
	// Use this for initialization
	void Start () 
	{
		initTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time - initTime > lifetimeInSeconds)
		{
			Destroy(gameObject);
		}
	}
}
