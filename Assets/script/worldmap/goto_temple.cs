using UnityEngine;
using System.Collections;

public class goto_temple : MonoBehaviour {

	void OnMouseUpAsButton() {
		
		Application.LoadLevel ("stage-temple");
		gameObject.SetActive (false);
		GameObject.Find ("worldmap").SetActive (false);
	}
}
