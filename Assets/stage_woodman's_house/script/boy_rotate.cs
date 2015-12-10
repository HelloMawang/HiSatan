using UnityEngine;
using System.Collections;

public class boy_rotate : MonoBehaviour {

	public GameObject boy;
	bool onlyone = false;
	void Update(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 13) {
			if (!onlyone) {
				boy.gameObject.transform.Rotate (new Vector3 (0f, 180f, 0f));

				GameObject.Find ("Boy").GetComponent<player_state> ().is_Rotate = true;
				onlyone =true;
			}
		}
	}
}
