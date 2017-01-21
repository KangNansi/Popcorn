using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2Fleche : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void SetSprite(Sprite spr)
    {
        GetComponent<SpriteRenderer>().sprite = spr;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
