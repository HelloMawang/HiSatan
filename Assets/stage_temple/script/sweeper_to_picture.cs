using UnityEngine;
using System.Collections;

public class sweeper_to_picture : MonoBehaviour {
	
	public GameObject picture;
	public GameObject sweeper;
	public GameObject crown;
	public GameObject thorn_crown;
	public GameObject neckless;
	public GameObject new_background;
	public GameObject picture_out1;
	public GameObject picture_out2;

	void Update () {
		Vector3 lp = sweeper.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 3f) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){				
					thorn_crown.SetActive (false);
					crown.SetActive (true);
					neckless.SetActive (true);
					new_background.SetActive (true);
					GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (sweeper);
					GameObject.Find ("blank").GetComponent<inven> ().dragitem = false;
					GameObject.Find("EventSystem").GetComponent<on_correcteffect>().StopCoroutine ("on_effect");
				}
			}
		}
		
	}

}
