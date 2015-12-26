using UnityEngine;
using System.Collections;

public class view_scene : MonoBehaviour {
	
	public int location;
	
	void OnMouseUpAsButton() {
		if (location == 8) {
			if(GameObject.Find("Boy").GetComponent<player_state>().his_position==4)
				GameObject.Find ("EventSystem").GetComponent<view> ().view_change (location);
		}
		else
		GameObject.Find ("EventSystem").GetComponent<view> ().view_change (location);
	}
}
