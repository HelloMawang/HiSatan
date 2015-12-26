using UnityEngine;
using System.Collections;

public class new_axe_to_tree : MonoBehaviour {

	public GameObject new_axe;
	public GameObject tree_area;
	public GameObject tree1;
	public GameObject tree2;
	public GameObject cat_on_tree;
	public GameObject jumping_cat;
	public GameObject girl;
	public GameObject main_camera;
	
	void Update () {
		Vector3 lp = tree_area.transform.position;
		float dis = Vector3.Distance (new_axe.transform.position, lp);
		
		if (dis < 1.5f ) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){
					
					StartCoroutine("fall_tree");

				}
			}
		}
		
	}
	IEnumerator fall_tree(){
		yield return new WaitForSeconds (1f);
		tree1.SetActive (false);
		tree2.SetActive (true);
		cat_on_tree.SetActive (false);
		jumping_cat.SetActive (true);
		yield return new WaitForSeconds (1f);
		jumping_cat.SetActive (false);
		girl.SetActive (true);
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
		yield return new WaitForSeconds (2f);
		GameObject.Find ("soulstone_manager").transform.position = new Vector3 (main_camera.transform.position.x, main_camera.transform.position.y, 0f);
		GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().get_soulstone (1, 1);
		yield return new WaitForSeconds (3f);
		GameObject.Find ("soulstone_interface").SetActive (false);
		GameObject.Find ("World_map").GetComponent<worldmap_manage>().go_to();
		
	}
}
