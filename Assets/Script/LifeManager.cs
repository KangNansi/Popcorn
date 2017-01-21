using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	public int Gm;
	public float timer;

    public Text timerText;


	// Use this for initialization
	void Start () {
		
		timer = 0;
		Gm = 120;
	}
	
	// Update is called once per frame
	void Update () {
        //Peut être déplacer ça dans un FixedUpdate pour qu'il se pause si timescale = 0
		MinusLife ();
		checkLife ();
       // timerText.text = (int)Gm / 60 + ":" + (int)Gm % 60;
	}
    
	void MinusLife(){
		
		timer = timer + 0.5f * Time.deltaTime;

		if (timer >=1 ) {
			Gm -= 1 ;
			timer = 0;
		}

	}

	void checkLife(){
		if (Gm <=0){
			SceneManager.LoadScene ("SceneGameOver", LoadSceneMode.Single);
		}
	}
}
