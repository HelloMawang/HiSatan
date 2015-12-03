using UnityEngine;
using System.Collections;

public class chicken_to_die : MonoBehaviour {

	public GameObject area;
	public GameObject chicken_object;

	void Update(){
		
		Vector3 lp = area.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 0.5f) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1){
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){

				chicken_object.SetActive(true);
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (this.gameObject);

			}
			}
		}
		
	}

}
