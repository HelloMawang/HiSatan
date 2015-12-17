using UnityEngine;
using System.Collections;

public class startposition_residence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GameObject.Find ("Boy").transform.position = new Vector3(-6f,-1f,0f);
	}
	

}
