using UnityEngine;
using System.Collections;

public class blood_to_circle : MonoBehaviour {

	public GameObject area;
	public GameObject blood;

	public GameObject worldmap;
	void Update(){
		
		Vector3 lp = area.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 0.5f) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1){
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){
				
				worldmap.SetActive(true);
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (blood);
				
			}
			}
		}
		
	}
}
