using UnityEngine;
using System.Collections;

public class devilchange : MonoBehaviour {

	void OnMouseUpAsButton(){

		GameObject.Find ("Boy").GetComponent<player_manager> ().devil_change ();

	}
}
