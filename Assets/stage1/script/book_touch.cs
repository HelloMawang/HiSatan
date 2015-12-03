using UnityEngine;
using System.Collections;

public class book_touch : MonoBehaviour {

	public GameObject book_magnified;



	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2) {
			book_magnified.SetActive (true);
		}
	}
	void Update(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				book_magnified.SetActive (false);
			}
		}
	}
}
