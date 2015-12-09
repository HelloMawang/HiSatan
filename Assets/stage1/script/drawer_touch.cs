using UnityEngine;
using System.Collections;

public class drawer_touch : MonoBehaviour {

	public GameObject drawer_open;
	public GameObject empty_open;
	public GameObject cursor_hand;
	public GameObject this_item_1;
	public GameObject this_item_2;
	public AudioSource open;
	public AudioSource close;

	private bool in_item = true;
	private bool is_open = false;
	void OnMouseUpAsButton(){
		if (in_item == true &&is_open==false) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2){
				drawer_open.SetActive (true);
				open.Play();
				is_open = true;
			}

		} 
		else if (in_item == false &&is_open==false) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2){
				empty_open.SetActive (true);
				open.Play();
				is_open = true;
			}
			
		}
		else {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2){
				if(in_item == true){
				GameObject.Find ("item").GetComponent <manage_inven>().push_item(this_item_1);
				GameObject.Find ("item").GetComponent <manage_inven>().push_item(this_item_2);
				drawer_open.SetActive (false);
				close.Play ();
					is_open=false;
				cursor_hand.SetActive(false);
				Cursor.visible = true;
					in_item=false;
				}
				else{
					empty_open.SetActive(false);
					close.Play();
					cursor_hand.SetActive(false);
					Cursor.visible = true;
					is_open=false;
				}

			}
		}
	
	}
	/*
	IEnumerator delete_this(){
	}
*/
}
