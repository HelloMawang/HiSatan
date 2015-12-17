using UnityEngine;
using System.Collections;

public class start_temple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GameObject.Find ("World_map").transform.position = new Vector3 (1.748703f-18f, 0.66f, 0f);
		GameObject.Find ("Boy").transform.position = new Vector3 (-21f, -2f, 0f);
		
	}

}
