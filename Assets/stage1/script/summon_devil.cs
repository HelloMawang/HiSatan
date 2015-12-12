using UnityEngine;
using System.Collections;

public class summon_devil : MonoBehaviour {

	public GameObject worldmap;
	public GameObject soulstone;
	bool check = false;
	void Update(){
		if (!check) {
			StartCoroutine ("summoned");
			check=true;	
		}
	}

	IEnumerator summoned(){
		
		GameObject.Find ("Text_text").GetComponent<text_manager> ().change_sentence (2);
		yield return new WaitForSeconds (8f);
		soulstone.SetActive (true);
		GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().set_0 ();
		yield return new WaitForSeconds (4f);
		soulstone.SetActive (false);
		worldmap.SetActive (true);
	}
}
