using UnityEngine;
using System.Collections;

public class put_candle : MonoBehaviour {

	public GameObject put_area;
	public GameObject obj_candle; 

	void Update(){
		
		Vector3 lp = put_area.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 2f && put_area.activeSelf) {

			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1){
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){

				obj_candle.SetActive(true);
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (this.gameObject);
				
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
			}
			}
		}
		
	}

}
