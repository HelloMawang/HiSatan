using UnityEngine;
using System.Collections;

public class sculpture_touch : MonoBehaviour {

	public GameObject[] trueending = new GameObject[15];
	public GameObject normalending;
	public GameObject[] badending = new GameObject[4];

	public MovieTexture truending_MT;
	public GameObject trueeing_P;

	public GameObject credit_page;
	void OnMouseUpAsButton(){
		if (GameObject.Find ("Boy").GetComponent<player_manager> ().use_devil >= 2) {
			//badending
			StartCoroutine("badend");
		} else if (GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().temple == 2
			&& GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().residence == 2
			&& GameObject.Find ("soulstone_manager").GetComponent<soulstone_manage> ().woodman == 2) {
			StartCoroutine("trueend");
			//trueending
		} else {
			StartCoroutine("normalend");
			//normalending
		}
	}

	IEnumerator badend(){
		yield return new WaitForSeconds (1f);
		badending [0].SetActive (true);
		for (int i=1; i<4; i++) {
			yield return new WaitForSeconds (3f);
			badending [i].SetActive (true);
			badending [i-1].SetActive (false);

		}
		yield return new WaitForSeconds (4f);
		//Application.Quit();
		
		StartCoroutine ("show_credit");

	}
	IEnumerator trueend(){
		yield return new WaitForSeconds (1f);
		trueeing_P.SetActive (true);
		truending_MT.Play();
		yield return new WaitForSeconds (80f);
		//Application.Quit();
		
		StartCoroutine ("show_credit");
	}
	IEnumerator normalend(){
		GameObject.Find ("Text_text").GetComponent<text_manager_final> ().change_sentence (1);
		yield return new WaitForSeconds (4f);
		normalending.SetActive (true);
		yield return new WaitForSeconds (4f);
		//Application.Quit();
		
		StartCoroutine ("show_credit");
	}

	IEnumerator show_credit(){
		
		Destroy (GameObject.Find ("Boy"));
		Destroy(GameObject.Find("soulstone_manager"));
		Destroy (GameObject.Find ("World_map"));
		credit_page.SetActive (true);
		yield return new WaitForSeconds(5f);
		
		Application.LoadLevel ("title");
	}
}
