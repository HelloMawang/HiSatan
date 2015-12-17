using UnityEngine;
using System.Collections;

public class goto_final : MonoBehaviour {

	void OnMouseUpAsButton() {
		
		Application.LoadLevel ("stage_final");
		gameObject.SetActive (false);
		GameObject.Find ("worldmap").SetActive (false);
	}
}
