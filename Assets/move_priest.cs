using UnityEngine;
using System.Collections;

public class move_priest : MonoBehaviour {
	public GameObject priest1;
	public GameObject priest2;
	public bool chk = false;

	void Update () {
		if (chk == false) {
			if (GameObject.Find ("Boy").GetComponent <player_state> ().his_position == 3) {
				priest1.SetActive (false);
				priest2.SetActive (true);
			} else if (GameObject.Find ("Boy").GetComponent <player_state> ().his_position != 3) {
				priest1.SetActive (true);
				priest2.SetActive (false);
			}
		}
	}
}
