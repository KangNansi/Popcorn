using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out hit))
            return;
        IActivable obj = hit.collider.GetComponent<IActivable>();
        if (obj != null)
            obj.OnHover();
        if (Input.GetMouseButtonDown(0) && obj!=null)
        {
            hit.collider.GetComponent<IActivable>().OnClicked();
        }
	}
}
