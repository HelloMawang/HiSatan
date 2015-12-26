using UnityEngine;
using System.Collections;

public class can_get_soulstone : MonoBehaviour {

	public GameObject real_soulstone;

	public void change_stone(){
		real_soulstone.SetActive (true);
		gameObject.SetActive (false);
	}
}
