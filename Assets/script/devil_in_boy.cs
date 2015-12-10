using UnityEngine;
using System.Collections;

public class devil_in_boy : MonoBehaviour {

	public GameObject devil_effect;

	public bool is_devil_able = false;

	void Update(){
		if (is_devil_able == true) {
			devil_effect.SetActive (true);
		} else {
			devil_effect.SetActive(false);
		}
	}
}
