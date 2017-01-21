using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvelsManager : MonoBehaviour {

	public AudioSource backMusic;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}



	//Menu Acceuil

	public void playLevel () {
		
		SceneManager.LoadScene ("Scene1", LoadSceneMode.Single);
	}
	public void playCredits() {

		SceneManager.LoadScene ("SceneCredits", LoadSceneMode.Single);
	}
	public void quit() {

		Application.Quit ();
	}


}
