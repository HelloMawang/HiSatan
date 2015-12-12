using UnityEngine;
using System.Collections;

public class enter_house : MonoBehaviour {

	bool onlyone =false;
	// Update is called once per frame
	void Update () {
		if (!onlyone) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 3) {

				GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (0);
				onlyone = true;
			}
		}
	}
}
