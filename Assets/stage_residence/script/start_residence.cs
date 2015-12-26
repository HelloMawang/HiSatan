using UnityEngine;
using System.Collections;

public class start_residence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Cursor.visible = true;
		GameObject.Find ("World_map").transform.position = new Vector3 (1.748703f, 0.66f, 0f);
		GameObject.Find ("Boy").transform.position = new Vector3 (-6f, -2f, 0f);
	
	}

}
