using UnityEngine;
using System.Collections;

public class fix_axe : MonoBehaviour {

	public GameObject fixed_axe;
	public GameObject cutton;
	
	void Update () {
		Vector3 lp = cutton.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		if (dis < 0.5f ) {
			GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
			if(Input.GetKeyUp(KeyCode.Mouse0)){
				
				
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this.gameObject);
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(cutton);
				
				GameObject.Find ("item").GetComponent <manage_inven> ().push_item(fixed_axe);
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
			}
		}
		
	}
}
