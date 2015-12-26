using UnityEngine;
using System.Collections;

public class goto_final : MonoBehaviour {

	void OnMouseUpAsButton() {

		if (GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().temple != 0
			&& GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().residence != 0
			&& GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().woodman != 0) {
			Application.LoadLevel ("stage_final");
			gameObject.SetActive (false);
			GameObject.Find ("worldmap").SetActive (false);
		}
	}
}
