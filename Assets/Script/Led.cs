using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Led : State {
    public Material LedOn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (state == 1)
            GetComponent<MeshRenderer>().material = LedOn;
       // if(state==1)GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(1, 0, 0));
    }
}
