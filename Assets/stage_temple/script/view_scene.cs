using UnityEngine;
using System.Collections;

public class view_scene : MonoBehaviour {
	
	public GameObject player;
	public int location;
	
	void OnMouseUpAsButton() {
		 
		GameObject.Find ("EventSystem").GetComponent<view> ().view_change (location);
	}
}
