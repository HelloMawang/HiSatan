using UnityEngine;
using System.Collections;

public class corrider_text : MonoBehaviour {
	
	bool onlyone = false;

	// Update is called once per frame
	void Update () {
		if (!onlyone) {
			if(GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 6){
			onlyone = true;
			StartCoroutine("print_text");
			}
		}
	}
	IEnumerator print_text(){

			GameObject.Find ("Text_text").GetComponent<text_manager_residence> ().change_sentence (1);

			yield return new WaitForSeconds (3f);
		GameObject.Find ("Text_text").GetComponent<text_manager_residence> ().change_sentence (2);
	}
}
