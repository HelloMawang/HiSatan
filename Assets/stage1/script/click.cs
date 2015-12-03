using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {

	public GameObject this_item;
	public GameObject cursor_hand;
	public int enable_location;

	void OnMouseUpAsButton(){


		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == enable_location) {

			Cursor.visible = true;
			cursor_hand.SetActive (false);
		
			Destroy (this.gameObject);
			GameObject.Find ("item").GetComponent <manage_inven> ().push_item (this_item);

		}
	}
}
