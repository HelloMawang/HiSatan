using UnityEngine;
using System.Collections;

public class goto_palace : MonoBehaviour {

	void OnMouseUpAsButton() {
		
		Application.LoadLevel ("stage_palace");
		gameObject.SetActive (false);
		GameObject.Find ("worldmap").SetActive (false);
	}
}
