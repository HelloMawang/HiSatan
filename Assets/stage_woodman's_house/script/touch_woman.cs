using UnityEngine;
using System.Collections;

public class touch_woman : MonoBehaviour {

	public GameObject cartoon;
	public GameObject girl_icon;
	IEnumerator OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1) {
			cartoon.SetActive (true);
			yield return new WaitForSeconds (1f);
			girl_icon.SetActive (true);
		}
	}
}
