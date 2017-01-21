using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour {

	public int Gm;
	public float timer;


	// Use this for initialization
	void Start () {
		
		timer = 0;
		Gm = 120;
	}
	
	// Update is called once per frame
	void Update () {
		MinusLife ();
		checkLife ();
		
	}
	void MinusLife(){
		
		timer = timer + 0.5f * Time.deltaTime;

		if (timer >=1 ) {
			Gm -= 1 ;
			timer = 0;
		}
		Debug.Log (timer);
		Debug.Log (Gm);
	}

	void checkLife(){
		if (Gm <=0){
			SceneManager.LoadScene ("SceneGameOver", LoadSceneMode.Single);
		}
	}
}
