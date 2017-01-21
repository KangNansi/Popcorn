using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : State {
    public int nb_symbole;
    public List<CodeButton> buttons;
    public List<State> togglers; 
    bool[] goodCode;

    bool getRandomBool()
    {
        float r = UnityEngine.Random.Range(0.0f, 1.0f);
        return (r < 0.5) ? true : false;
    }

	// Use this for initialization
	void Start () {
        goodCode = new bool[buttons.Count];
        for (int i = 0; i < buttons.Count; i++)
        {
            goodCode[i] = getRandomBool();
            buttons[i].SetValue(UnityEngine.Random.Range(0, 5));
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (state != 0)
            return;
        for (int i = 0; i < buttons.Count; i++)
            if (buttons[i].state != (goodCode[i] ? 1 : 0))
                return;
        state = 1;
        for (int i = 0; i < togglers.Count; i++)
            togglers[i].state = (togglers[i].state==1)?0:1;
        Debug.Log("Resolved");
	}

    public void Toggle()
    {
        throw new NotImplementedException();
    }
}
