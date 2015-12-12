using UnityEngine;
using System.Collections;

public class title_effect : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.z>0)
			gameObject.transform.Translate (0f, 0f, -0.1f);
	
	}
}
