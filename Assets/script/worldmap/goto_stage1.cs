using UnityEngine;
using System.Collections;

public class goto_stage1 : MonoBehaviour {

	public MovieTexture mov;
	public GameObject board;
	// Update is called once per frame
	bool check =false;
	void Update () {
		if (!check) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				board.SetActive (true);
				mov.Play ();
				StartCoroutine ("delay_prol");
				check=true;

				//Application.LoadLevel ("stage1");
			}
		}
	}
	IEnumerator delay_prol(){
		yield return new WaitForSeconds (31f);
		Application.LoadLevel ("stage1");
	}
}
