using UnityEngine;
using System.Collections;

public class escape : MonoBehaviour {

	public GameObject captured;

	void OnMouseUpAsButton(){

		captured.SetActive (false);
		Destroy (this);
	}
}
