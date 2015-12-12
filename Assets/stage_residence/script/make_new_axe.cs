using UnityEngine;
using System.Collections;

public class make_new_axe : MonoBehaviour {

	public GameObject new_axe;
	public GameObject axe_head;
	
	void Update () {
		Vector3 lp = axe_head.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		if (dis < 0.5f ) {
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){
					
					GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this.gameObject);
					GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(axe_head);
				
				GameObject.Find ("item").GetComponent <manage_inven> ().push_item(new_axe);
					GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				}
		}
		
	}
}
