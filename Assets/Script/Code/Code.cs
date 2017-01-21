using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : State {
    public int nb_symbole;
    public List<CodeButton> buttons;
    public List<State> togglers;
    public List<Pictogramme> pictos;
    bool[] goodCode;
    int[] values;

    bool getRandomBool()
    {
        float r = UnityEngine.Random.Range(0.0f, 1.0f);
        return (r < 0.5) ? true : false;
    }

	// Use this for initialization
	void Start () {
        goodCode = new bool[buttons.Count];
        values = new int[9];
        for (int i = 0; i < 9; i++)
            values[i] = i;
        for(int i = 0; i < 9; i++)
        {
            int temp = values[i];
            int rand = UnityEngine.Random.Range(0, 8);
            values[i] = values[rand];
            values[rand] = temp;
        }
        int p=0;
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].SetValue(values[i]);
            goodCode[i] = false;
        }
        while (p < pictos.Count)
        {
            int rand = UnityEngine.Random.Range(0, 9);
            if (!goodCode[rand])
            {
                goodCode[rand] = true;
                pictos[p].SetValue(values[rand]);
                p++;
            }
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
