using UnityEngine;
using System.Collections;

public class worldmap_manage : MonoBehaviour {

	public GameObject worldmap;

	void Update () {
		DontDestroyOnLoad (gameObject);	
	}
	public void go_to(){
		worldmap.SetActive (true);
	}
}
