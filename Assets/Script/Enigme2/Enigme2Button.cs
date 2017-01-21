using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme2Button : State, IActivable {
    Enigme2 cible;
    public int x, y;

    public void OnClicked()
    {
        cible.Clicked(x, y);
    }

    public void OnHover()
    {
        throw new NotImplementedException();
    }

    public void OnReleased()
    {
        throw new NotImplementedException();
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
