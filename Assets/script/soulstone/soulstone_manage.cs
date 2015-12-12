using UnityEngine;
using System.Collections;

public class soulstone_manage : MonoBehaviour {

	public GameObject this_object;

	public GameObject temple_stone;
	public GameObject residence_stone;
	public GameObject palace_stone;
	public GameObject woodman_stone;
	public GameObject temple_darkstone;
	public GameObject residence_darkstone;
	public GameObject palace_darkstone;
	public GameObject woodman_darkstone;
	public short temple;
	public short residence;
	public short palace;
	public short woodman;
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (gameObject);	
	}
	public void  set_0(){
		temple = 0;
		residence = 0;
		palace = 0;
		woodman = 0;
	}
	void Awake(){
		if (temple == 1) {
			temple_stone.SetActive (true);
			temple_darkstone.SetActive (false);
		} else if (temple == 2) {
			temple_stone.SetActive (false);
			temple_darkstone.SetActive (true);
		} else {
			temple_darkstone.SetActive(false);
			temple_stone.SetActive (false);
		}

		if (residence == 1) {
			residence_stone.SetActive (true);
			residence_darkstone.SetActive (false);
		} else if (residence == 2) {
			residence_stone.SetActive (false);
			residence_darkstone.SetActive (true);
		} else {
			residence_stone.SetActive (false);
			residence_darkstone.SetActive(false);
		}

		if (palace == 1) {
			palace_stone.SetActive (true);
			palace_darkstone.SetActive(false);
		}else if(palace==2){
			palace_stone.SetActive(false);
			palace_darkstone.SetActive(true);
		}else{
			palace_stone.SetActive (false);
			palace_darkstone.SetActive(true);
		}

		if (woodman == 1) {
			woodman_stone.SetActive (true);
			woodman_darkstone.SetActive (false);
		} else if (woodman == 2) {
			woodman_stone.SetActive (false);
			woodman_darkstone.SetActive (true);
		} else {
			woodman_stone.SetActive (false);
			woodman_darkstone.SetActive(false);
		}
	}
	public void get_soulstone(short stage,short soulstone ){
		this_object.gameObject.SetActive (true);
		if (stage == 0) {
			temple = soulstone;
			if (temple == 1) {
				temple_stone.SetActive (true);
				temple_darkstone.SetActive (false);
			} else if (temple == 2) {
				temple_stone.SetActive (false);
				temple_darkstone.SetActive (true);
			}
		} else if (stage == 1) {
			residence =soulstone;
			if (residence == 1) {
				residence_stone.SetActive (true);
				residence_darkstone.SetActive (false);
			} else if (residence == 2) {
				residence_stone.SetActive (false);
				residence_darkstone.SetActive (true);
			}
		} else if (stage == 2) {
			palace = soulstone;
			if (palace == 1) {
				palace_stone.SetActive (true);
				palace_darkstone.SetActive(false);
			}else if(palace==2){
				palace_stone.SetActive(false);
				palace_darkstone.SetActive(true);
			}
		} else {
			woodman =soulstone;
			if (woodman == 1) {
				woodman_stone.SetActive (true);
				woodman_darkstone.SetActive (false);
			} else if (woodman == 2) {
				woodman_stone.SetActive (false);
				woodman_darkstone.SetActive (true);
			}
		}
	}
}
