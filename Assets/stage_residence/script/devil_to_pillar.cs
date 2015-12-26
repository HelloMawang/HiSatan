using UnityEngine;
using System.Collections;

public class devil_to_pillar : MonoBehaviour {
	
	public GameObject devileffect;
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Boy").GetComponent<player_manager>().is_devil == true) {
			devileffect.SetActive(true);
			devileffect.transform.position = gameObject.transform.position;
		}
		else devileffect.SetActive(false);
	}
}
