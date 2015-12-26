using UnityEngine;
using System.Collections;

public class can_use_devil_temple : MonoBehaviour {

	void Update () {
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2) {
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = true;
		} else
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = false;
	}
}
