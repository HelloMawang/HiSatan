using UnityEngine;
using System.Collections;

public class get_soulstone_temple : MonoBehaviour {

	public GameObject main_camera;
	public GameObject temple_happy_priest;
	IEnumerator OnMouseUpAsButton(){
		GameObject.Find ("soulstone_manager").transform.position = new Vector3 (main_camera.transform.position.x, main_camera.transform.position.y, 0f);
		if(temple_happy_priest.activeSelf==true)
			GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().get_soulstone (0, 1);
		else
			GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().get_soulstone (0, 2);
		yield return new WaitForSeconds(3f);
		GameObject.Find ("soulstone_interface").SetActive (false);
		GameObject.Find ("World_map").GetComponent<worldmap_manage> ().go_to ();
		
	}
}
