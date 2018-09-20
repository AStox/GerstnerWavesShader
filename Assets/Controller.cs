using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	float turnspeed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			Debug.Log("sdf");
			transform.Translate(Vector3.forward);
		}	
		if (Input.GetKey("a"))
		{
			transform.Rotate(0,-turnspeed,0);
		}
		if (Input.GetKey("d"))
		{
			transform.Rotate(0,turnspeed,0);
		}	
	}
}
