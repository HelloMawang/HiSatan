using UnityEngine;
using System.Collections;

public class torch_to_stairs : MonoBehaviour {
	public GameObject torch;
	public GameObject stairs_fired;
	public GameObject stairs;
	void Update(){
		
		Vector3 lp = stairs.transform.position;
		float dis = Vector3.Distance (torch.transform.position, lp);
		
		
		if (dis < 0.5f) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 8){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){
					
					StartCoroutine("fire_stairs");
					
				}
			}
		}
		
	}
	IEnumerator fire_stairs(){

		yield return new WaitForSeconds(1f);
		
		stairs_fired.SetActive (true);
		
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (torch.gameObject);
	}
}
