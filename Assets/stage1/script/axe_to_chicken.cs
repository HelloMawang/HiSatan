using UnityEngine;
using System.Collections;

public class axe_to_chicken : MonoBehaviour {

	public GameObject chicken;
	public GameObject chicken_blood;
<<<<<<< HEAD
	
=======


>>>>>>> master
	bool onlyone = false;
	// Update is called once per frame
	void Update () {
		Vector3 lp = chicken.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 2f && chicken.activeSelf) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 1){
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){

				StartCoroutine("slash");




			}
			}
		}
	
	}
	IEnumerator slash(){

		if (!onlyone) {
			GameObject.Find ("EventSystem").GetComponent <sound_play> ().play_sound (); 
			onlyone = true;
		
		}
		GameObject.Find ("Boy").GetComponent<player_state> ().axe_hit (false, 4f);
		Destroy (chicken);
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this.gameObject);
		
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(chicken_blood);
		
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;

		yield return null;

	}
}
