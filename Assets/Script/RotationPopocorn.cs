using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPopocorn : MonoBehaviour {

	public float coefV;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.transform.Rotate ( Vector3.up * coefV * Time.deltaTime);
	}
}
