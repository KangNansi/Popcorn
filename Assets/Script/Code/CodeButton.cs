using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeButton : State, IActivable
{
    public int val;
    bool hover = false;

    public void OnHover()
    {
        hover = true;
    }

    public void OnClicked()
    {
        state = (state==1)?0:1;
        
    }

    public void SetValue(int v)
    {
        val = v;
        GetComponentInChildren<Pictogramme>().SetValue(val);
    }

    public int GetValue()
    {
        return val;
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (hover)
            GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(1, 0, 0));
        else
            if(state==0)
                GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(1, 1, 1));
            else
                GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(0, 1, 0));
        hover = false;
    }

    public void OnReleased()
    {
        throw new NotImplementedException();
    }
}
