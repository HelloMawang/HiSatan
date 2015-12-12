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
		yield return new WaitForSeconds (3f);
		soulstone.SetActive (true);
		GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().set_0 ();
		yield return new WaitForSeconds (2f);
		soulstone.SetActive (false);
		worldmap.SetActive (true);
	}
}
