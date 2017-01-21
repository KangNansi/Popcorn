using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	public GameObject pause;



	// Use this for initialization
	void Start () {
		pause.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

		pauseEnable ();
	}


	//Menu Pause (sauf quit)
	public void pauseEnable () {
		if (Input.GetButtonDown("Cancel")){
			pause.SetActive (true);
		}
	}

	public void backButton () {

		pause.SetActive(false);
	}
	public void restartButton(){
		Scene actualscene = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (actualscene.name, LoadSceneMode.Single);
	}
		
}
