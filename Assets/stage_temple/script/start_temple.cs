using UnityEngine;
using System.Collections;

public class start_temple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Cursor.visible = true;
		GameObject.Find ("World_map").transform.position = new Vector3 (1.748703f-18f, 0.66f, 0f);
		GameObject.Find ("Boy").transform.position = new Vector3 (-21f, -2f, 0f);
		StartCoroutine ("print_text");

	}
	IEnumerator print_text(){
		GameObject.Find ("Text_text").GetComponent<text_manager_temple> ().change_sentence (0);
		yield return new WaitForSeconds (4f);
		GameObject.Find ("Text_text").GetComponent<text_manager_temple> ().change_sentence (5);
	}

}
