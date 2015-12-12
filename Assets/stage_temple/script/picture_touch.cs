using UnityEngine;
using System.Collections;

public class picture_touch : MonoBehaviour {
	
	public GameObject picture_magnified;
	public GameObject thorn;
	public GameObject crown;
	public GameObject neckless;
	public GameObject picture_out1;
	public GameObject picture_out2;

	
	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5) {
			picture_magnified.SetActive (true);
			thorn.SetActive(true);
			picture_out1.SetActive(true);
			picture_out2.SetActive(true);
		}
	}

	public void button(){
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5) {
			picture_magnified.SetActive (false);
			thorn.SetActive (false);
			picture_out1.SetActive (false);
			picture_out2.SetActive (false);
			crown.SetActive (false);
			neckless.SetActive (false);
		}
	}
}

