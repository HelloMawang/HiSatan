using UnityEngine;
using System.Collections;

public class axe_to_pillar_onemore : MonoBehaviour {

	public GameObject new_axe;
	public GameObject pillar_area;
	public GameObject pillar;
	public GameObject pillar1;
	public GameObject pillar2;
	public GameObject pillar3;
	public GameObject pillar4;
	public GameObject dust;
	public GameObject movearea_kitchen;
	public GameObject movearea_room;


	//
	public GameObject background;
	public GameObject girl_with_cat;
	public GameObject cat;
	public GameObject ori_tree;
	public GameObject girl;
	public GameObject tree;
	public GameObject moveareal;
	public GameObject movearear;
	//

	public GameObject back1;
	public GameObject frontback;
	public GameObject soulstone;
	void Update () {
		Vector3 lp = pillar_area.transform.position;
		float dis = Vector3.Distance (new_axe.transform.position, lp);
		
		if (dis < 1.5f ) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 8){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){
					
					StartCoroutine("break_pillar");
					
				}
			}
		}
		
	}
	IEnumerator break_pillar(){
		GameObject.Find ("Text_text").GetComponent<text_manager_residence> ().change_sentence (3);
		Destroy( background);
		Destroy( girl);
		Destroy( tree);
		Destroy( moveareal);
		Destroy( movearear);
		back1.SetActive (true);
		frontback.SetActive (true);
		soulstone.SetActive (true);

		yield return new WaitForSeconds (1f);
		movearea_kitchen.SetActive (false);
		movearea_room.SetActive (false);
		pillar.SetActive (false);
		pillar1.SetActive (true);
		pillar2.SetActive (true);
		pillar3.SetActive (true);
		pillar4.SetActive (true);
		yield return new WaitForSeconds (1f);
		dust.SetActive (true);
		
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(new_axe);
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
		
	}
}
