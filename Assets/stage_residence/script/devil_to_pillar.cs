using UnityEngine;
using System.Collections;

public class devil_to_pillar : MonoBehaviour {
	
	public GameObject devileffect;
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able == true) {
			devileffect.SetActive(true);
			devileffect.transform.position = gameObject.transform.position;
		}
		else devileffect.SetActive(false);
	}
}
