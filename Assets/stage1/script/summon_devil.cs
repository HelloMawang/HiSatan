using UnityEngine;
using System.Collections;

public class summon_devil : MonoBehaviour {

	public GameObject worldmap;

	void Update(){
		StartCoroutine ("summoned");
	}

	IEnumerator summoned(){
		yield return new WaitForSeconds (5f);
		worldmap.SetActive (true);
	}
}
