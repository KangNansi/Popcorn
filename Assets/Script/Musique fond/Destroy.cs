using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {

	void Update(){

		Scene actualscene = SceneManager.GetActiveScene ();

		//Debug.Log (actualscene.name);

		if (actualscene.name != "Scene1") {
			DestroyImmediate (GameObject.Find("AudioBackground(Clone)"));
		}
	}
}
