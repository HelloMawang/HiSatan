using UnityEngine;
using System.Collections;

public class devil_pillar_touch : MonoBehaviour {

	void OnMouseUpAsButton(){
		if(GameObject.Find ("Boy").GetComponent<player_manager>().is_devil==true)
		GameObject.Find ("EventSystem").GetComponent<axe_to_pillar_onemore> ().devil_break_pillar ();
	}
}
