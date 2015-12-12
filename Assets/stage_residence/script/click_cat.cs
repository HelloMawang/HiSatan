using UnityEngine;
using System.Collections;

public class click_cat : MonoBehaviour {

	public AudioSource yayong;

	void OnMouseDown(){
		yayong.Play ();
	}
}
