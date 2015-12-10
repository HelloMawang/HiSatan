using UnityEngine;
using System.Collections;

public class touch_man : MonoBehaviour {

	public GameObject cartoon;
	public GameObject statue_icon;
	IEnumerator OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5) {
			cartoon.SetActive (true);
			yield return new WaitForSeconds (1f);
			statue_icon.SetActive (true);
		}
	}
}
