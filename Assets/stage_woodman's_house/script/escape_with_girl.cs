using UnityEngine;
using System.Collections;

public class escape_with_girl : MonoBehaviour {

	public GameObject boy;
	public GameObject main_camera;
	public GameObject captured_boy;
	public GameObject woman;
	public GameObject womanandgirl;
	void OnMouseUpAsButton() {
		if (captured_boy.activeSelf == false) {
			boy.transform.position = new Vector3 (29.88935f, -2f, 0f);
			main_camera.transform.position = new Vector3 (34.1f, 0.02f, -8.6f);
			GameObject.Find ("Boy").GetComponent<player_state> ().his_position = 8;
			woman.SetActive(false);
			womanandgirl.SetActive(true);
			Destroy(GameObject.Find("LHW-inside of stair").GetComponent<touch_to_move>());
		}
	}
}
