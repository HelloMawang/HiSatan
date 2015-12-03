using UnityEngine;
using System.Collections;

public class coop_touch : MonoBehaviour {

	public GameObject this_item;
	public GameObject coop_open;
	public GameObject cursor_hand;
	public AudioSource open;

	private bool check = false;
	void OnMouseUpAsButton(){
		
		if (check == false) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 3){
			coop_open.SetActive (true);
			check = true;
			open.Play ();
			}
		} else {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 3){
			GameObject.Find ("item").GetComponent <manage_inven>().push_item(this_item);
			coop_open.SetActive(false);
			gameObject.SetActive(false);
			cursor_hand.SetActive(false);
			Cursor.visible = true;
			}
		}
		
	}
}
