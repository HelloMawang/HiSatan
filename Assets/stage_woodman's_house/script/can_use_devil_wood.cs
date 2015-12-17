using UnityEngine;
using System.Collections;

public class can_use_devil_wood : MonoBehaviour {

	public GameObject boy_captured;
	public GameObject girl_captured;

	public GameObject devil_area;
	void Update () {
		if (boy_captured.activeSelf == false && girl_captured.activeSelf==true) {
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = true;
		} else
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = false;


		if (GameObject.Find ("Boy").GetComponent<player_manager> ().is_devil == true) {
			devil_area.SetActive (true);
		} else {
			devil_area.SetActive(false);
		}
	}
}
