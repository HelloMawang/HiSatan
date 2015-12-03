using UnityEngine;
using System.Collections;

public class drawer_touch : MonoBehaviour {

	public GameObject drawer_open;
	public GameObject cursor_hand;
	public GameObject this_item_1;
	public GameObject this_item_2;
	public AudioSource open;
	public AudioSource close;

	private bool check =false ;
	IEnumerator OnMouseUpAsButton(){
		if (check == false) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2){
			drawer_open.SetActive (true);
			check = true;
			open.Play();
			}

		} else {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2){
			GameObject.Find ("item").GetComponent <manage_inven>().push_item(this_item_1);
			GameObject.Find ("item").GetComponent <manage_inven>().push_item(this_item_2);
			drawer_open.SetActive (false);
			close.Play ();

			cursor_hand.SetActive(false);
			Cursor.visible = true;
			
			yield return new WaitForSeconds(2f);
			
			gameObject.SetActive(false);
			}
		}
	
	}
	/*
	IEnumerator delete_this(){
	}
*/
}
