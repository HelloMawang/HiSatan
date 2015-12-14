using UnityEngine;
using System.Collections;

public class click_fountain : MonoBehaviour {
	
	public GameObject top;
	public GameObject right;
	public GameObject left;
	public int state=1;
	
	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2) {
			if (state == 0) {
				top.SetActive (true);
				left.SetActive (false);
				state = 1;
			} else if (state == 1) {
				top.SetActive (false);
				right.SetActive (true);
				state = 2;
			} else if (state == 2) {
				right.SetActive (false);
				top.SetActive (true);
				state = 3;
			} else if (state == 3) {
				top.SetActive (false);
				left.SetActive (true);
				state = 0;
			}
		}
	}
}

