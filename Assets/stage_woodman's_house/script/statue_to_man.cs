using UnityEngine;
using System.Collections;

public class statue_to_man : MonoBehaviour {

	public GameObject statue;
	public GameObject man;
	public GameObject finding_man;
	public GameObject open_safecracker;
	void Update(){
		
		Vector3 lp = man.transform.position;
		float dis = Vector3.Distance (statue.transform.position, lp);

		
		if (dis < 2f) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){

					StartCoroutine("fine_safecracker");
					
				}
			}
		}
		
	}
	IEnumerator fine_safecracker(){
		yield return new WaitForSeconds (1f);
		man.SetActive (false);
		finding_man.SetActive (true);
		open_safecracker.SetActive (true);
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (statue.gameObject);
	}
}
