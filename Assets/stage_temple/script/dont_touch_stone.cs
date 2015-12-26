using UnityEngine;
using System.Collections;

public class dont_touch_stone : MonoBehaviour {


	public GameObject ori_priest;
	public GameObject rev_priest;
	public GameObject rev_priest_hand;

	void OnMouseUpAsButton(){

		StopCoroutine ("stop_priest");
		StartCoroutine ("stop_priest");
	}
	IEnumerator stop_priest(){
		rev_priest_hand.SetActive (false);
		ori_priest.SetActive (false);
		rev_priest.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		rev_priest_hand.SetActive (true);
		yield return new WaitForSeconds(1f);
		rev_priest_hand.SetActive (false);
		ori_priest.SetActive (true);
		rev_priest.SetActive (false);

	}
}
