using UnityEngine;
using System.Collections;

public class on_correcteffect : MonoBehaviour {

	public GameObject correct_effect ;
	
	public void on_eff(){
		StopCoroutine ("on_effect");
		StartCoroutine ("on_effect");
	}

	IEnumerator on_effect(){

		correct_effect.SetActive (true);
		Vector3 scrSpace = Camera.main.WorldToScreenPoint (correct_effect.transform.position);
		Vector3 curScreenSpace = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenSpace);
		correct_effect.transform.position = curPosition;
		yield return new WaitForSeconds (0.02f);
		correct_effect.SetActive (false);
	}
}
