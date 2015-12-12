using UnityEngine;
using System.Collections;

public class get_soulstone_woodman : MonoBehaviour {

	public GameObject lying_man;

	public GameObject main_camera;
	IEnumerator OnMouseUpAsButton(){
		GameObject.Find ("soulstone_manager").transform.position = new Vector3 (main_camera.transform.position.x, main_camera.transform.position.y, 0f);
		if (lying_man.activeSelf) {
			GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().get_soulstone (3, 1);
		} else {
			GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().get_soulstone (3, 2);
		}
		yield return new WaitForSeconds(3f);
		GameObject.Find ("World_map").GetComponent<worldmap_manage> ().go_to ();
		
	}
}
