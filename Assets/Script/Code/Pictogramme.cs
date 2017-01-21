using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pictogramme : MonoBehaviour {
    int value;
    public List<Sprite> spr;

    public void SetValue(int v)
    {
        value = v;
        GetComponent<SpriteRenderer>().sprite = spr[v];
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {


    }
}
