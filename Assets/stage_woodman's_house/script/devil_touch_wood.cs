using UnityEngine;
using System.Collections;

public class devil_touch_wood : MonoBehaviour {
	public GameObject main_camera;
	public GameObject woman;
	public GameObject womanandgirl;
	public GameObject man_dead;
	void OnMouseUpAsButton(){
		man_dead.SetActive (true);
		StartCoroutine ("devil_wood");
	}

	IEnumerator devil_wood(){
		yield return new WaitForSeconds (3f);

		GameObject.Find("Boy").transform.position= new Vector3 (29.88935f, -2f, 0f);
		main_camera.transform.position = new Vector3 (34.1f, 0.02f, -8.6f);
		GameObject.Find ("Boy").GetComponent<player_state> ().his_position = 8;
		Destroy(GameObject.Find("LHW-inside of stair").GetComponent<touch_to_move>());
		woman.SetActive(false);
		womanandgirl.SetActive(true);
	}
}
