using UnityEngine;
using System.Collections;

public class carpet_click : MonoBehaviour {

	public GameObject carpet_roll;

	void OnMouseDown(){
		carpet_roll.SetActive (true);
		gameObject.SetActive (false);
		GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (6);
	}
}
