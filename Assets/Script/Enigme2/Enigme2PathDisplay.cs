using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme2PathDisplay : MonoBehaviour {
    public Sprite fleche_haut;
    public Sprite fleche_bas;
    public Sprite fleche_droite;
    public Sprite fleche_gauche;
    public Sprite plus;

    public float scale;
    public float distance;

    List<int> path;
	// Use this for initialization
	void Start () {
        
		
	}

    public void UpdatePath(List<int> p)
    {
        path = p;
        E2Fleche[] display = gameObject.GetComponentsInChildren<E2Fleche>();
        for (int i = 0; i < path.Count && i < display.Length; i++)
        {
            if (path[i] == 0) display[i].SetSprite(fleche_haut);
            if (path[i] == 1) display[i].SetSprite(fleche_bas);
            if (path[i] == 2) display[i].SetSprite(fleche_gauche);
            if (path[i] == 3) display[i].SetSprite(fleche_droite);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
