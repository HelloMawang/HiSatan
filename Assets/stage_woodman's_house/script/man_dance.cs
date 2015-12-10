using UnityEngine;
using System.Collections;

public class man_dance : MonoBehaviour {

	public GameObject body1;
	public GameObject body2;

	IEnumerator Start(){
		while (true) {
			
			body2.SetActive(true);
			body1.SetActive(false);
			yield return new WaitForSeconds(0.5f);
			body2.SetActive(false);
			body1.SetActive(true);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
