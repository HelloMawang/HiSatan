using UnityEngine;
using System.Collections;

public class goto_woodman : MonoBehaviour {

	void OnMouseUpAsButton() {
		
		Application.LoadLevel ("stage_woodmanshouse");
		gameObject.SetActive (false);
		GameObject.Find ("worldmap").SetActive (false);
	}
}
