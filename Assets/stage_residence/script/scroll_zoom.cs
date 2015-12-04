using UnityEngine;
using System.Collections;

public class scroll_zoom : MonoBehaviour {

	public GameObject scroll_zoomin;
	
	
	
	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 15) {
			scroll_zoomin.SetActive (true);
		}
	}
	void Update(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 15) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				scroll_zoomin.SetActive (false);
			}
		}
	}
}
