using UnityEngine;
using System.Collections;

public class devil_touch_temple : MonoBehaviour {

	public GameObject iceberg;
	public GameObject iceberg_priest;
	public GameObject priest;
	public AudioSource ssound;
	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<devil_in_boy> ().is_devil_able == true
		    && GameObject.Find("Boy").GetComponent<player_manager>().is_devil==true)
		StartCoroutine ("devil_temple");
	}
	
	IEnumerator devil_temple(){
		iceberg.SetActive (true);
		ssound.Play ();
		yield return new WaitForSeconds (1f);
		GameObject.Find ("Text_text").GetComponent<text_manager_temple> ().change_sentence (3);
		iceberg_priest.SetActive (true);
		priest.SetActive (false);
		GameObject.Find ("temple-soulstone").GetComponent<can_get_soulstone>().change_stone();
		GameObject.Find ("Boy").GetComponent<player_manager> ().use_devil += 1;
	}
}
