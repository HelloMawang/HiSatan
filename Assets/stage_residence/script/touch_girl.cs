using UnityEngine;
using System.Collections;

public class touch_girl : MonoBehaviour {

	public GameObject cartoon;
	public GameObject cat_icon;
	IEnumerator OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 2) {
			cartoon.SetActive (true);
			yield return new WaitForSeconds (1f);
			cat_icon.SetActive (true);
		}
	}
}
