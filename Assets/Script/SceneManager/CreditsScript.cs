﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		escapeCredits ();
	}



	//Menu Credits

	public void escapeCredits() {
		
		if (Input.GetButtonDown("Cancel")){
			SceneManager.LoadScene ("Scene0", LoadSceneMode.Single);
		}

	}

}