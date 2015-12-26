using UnityEngine;
using System.Collections;

public class carpet_click : MonoBehaviour {

	public GameObject carpet_roll;

	void OnMouseDown(){
		if(GameObject.Find("Boy").GetComponent<player_state>().his_position== 8){
		carpet_roll.SetActive (true);
		gameObject.SetActive (false);
		GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (6);
		}
	}
}
