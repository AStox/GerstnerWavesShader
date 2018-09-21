using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCircle : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z);
	}
}
