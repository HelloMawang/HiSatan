using UnityEngine;
using System.Collections;

public class erase_picture : MonoBehaviour {
	
	public GameObject picture;
	public GameObject sweeper;
	public GameObject crown;
	public GameObject thorn_crown;
	public GameObject neckless;
	public GameObject new_background;
	public GameObject picture_out1;
	public GameObject picture_out2;
	public GameObject bottle;
	public GameObject smoke_effect;
	//public GameObject bottle_after;
	int chk=0;

	void Update () {
		if(GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5){
			Vector3 lp_s = sweeper.transform.position;
			Vector3 lp_b = bottle.transform.position;
			float dis_s = Vector3.Distance (transform.position, lp_s);
			float dis_b = Vector3.Distance (transform.position, lp_b);

			if (dis_b < 3f) {
				if (chk==0){
					GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
					if(Input.GetKeyUp(KeyCode.Mouse0)){				
						chk=1;
						GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (bottle);
						GameObject.Find ("blank").GetComponent<inven> ().dragitem = false;
						GameObject.Find("EventSystem").GetComponent<on_correcteffect>().off_eff();
						GameObject.Find ("item").GetComponent <manage_inven>().push_item(bottle);
						smoke_effect.SetActive(true);
					}
				}
			}
			
			if (dis_s < 3f) {
				if (chk==1){
					GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
					if(Input.GetKeyUp(KeyCode.Mouse0)){				
						thorn_crown.SetActive (false);
						crown.SetActive (true);
						neckless.SetActive (true);
						new_background.SetActive (true);
						GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (sweeper);
						GameObject.Find ("blank").GetComponent<inven> ().dragitem = false;
						chk=2;
						GameObject.Find("EventSystem").GetComponent<on_correcteffect>().off_eff();
						smoke_effect.SetActive(false);
					}
				}
			}
		}
	}

}
