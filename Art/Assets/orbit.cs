using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {
	public GameObject target;
	public float radius; 
	public float speed;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(radius*Mathf.Cos(speed*Time.time/Mathf.PI),transform.position.y,radius*Mathf.Sin(speed*Time.time/Mathf.PI));
		transform.LookAt(target.transform.position);
	}
}
