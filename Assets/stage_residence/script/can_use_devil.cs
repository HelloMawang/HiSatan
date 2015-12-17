using UnityEngine;
using System.Collections;

public class can_use_devil : MonoBehaviour {
	
	void Start(){

		GameObject.Find ("soulstone_manager").GetComponent<player_manager> ().set_player ();

	}
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 8) {
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = true;
		} else
			GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able = false;
	}
}
