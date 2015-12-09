using UnityEngine;
using System.Collections;

public class goto_stage1 : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Application.LoadLevel ("stage1");
		}
	
	}
}
