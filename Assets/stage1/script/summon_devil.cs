using UnityEngine;
using System.Collections;

public class summon_devil : MonoBehaviour {

	public GameObject worldmap;
	public GameObject soulstone;

	void Update(){
		StartCoroutine ("summoned");
	}

	IEnumerator summoned(){
		yield return new WaitForSeconds (3f);
		soulstone.SetActive (true);
		yield return new WaitForSeconds (2f);
		soulstone.SetActive (false);
		worldmap.SetActive (true);
	}
}
