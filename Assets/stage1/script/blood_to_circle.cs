using UnityEngine;
using System.Collections;

public class blood_to_circle : MonoBehaviour {

	public GameObject area;
	public GameObject blood;
	public GameObject devil;
	public GameObject firecandle_1;
	public GameObject firecandle_2;
	public GameObject firecandle_3;

	public GameObject worldmap;
	void Update(){
		
		Vector3 lp = area.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 0.5f && firecandle_1.activeSelf && firecandle_2.activeSelf && firecandle_3.activeSelf) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1){
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){
				
					devil.SetActive(true);
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (blood);
				
			}
			}
		}
		
	}
}
