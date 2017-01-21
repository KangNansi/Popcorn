using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public new AudioSource audio;

	void Awake ()
	{

		if (!GameObject.Find ("AudioBackground(Clone)")) {
			Instantiate (audio);

		}
			
	}
}
