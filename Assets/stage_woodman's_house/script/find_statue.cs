using UnityEngine;
using System.Collections;

public class find_statue : MonoBehaviour {

	public GameObject statue;

	bool check;
	void Start(){
		check = false;
	}
	void OnMouseUpAsButton(){
		if (!check && GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 8) {

			StartCoroutine ("nawara_statue");
			check=true;
		}
	}
	IEnumerator nawara_statue(){
		for (int i=0; i<40; i++) {
			statue.transform.Translate (new Vector3 (-0.02f, 0f, 0f));
			statue.transform.Rotate(new Vector3(0f,0f,1f));
			yield return new WaitForSeconds(0.025f);
		
		}
	}
}
