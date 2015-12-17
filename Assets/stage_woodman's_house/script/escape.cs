using UnityEngine;
using System.Collections;

public class escape : MonoBehaviour {

	public GameObject captured;

	IEnumerator OnMouseUpAsButton(){
		GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (2);
		captured.SetActive (false);
		yield return new WaitForSeconds (2.2f);
		GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (3);
		
		gameObject.SetActive (false);
	}
}
