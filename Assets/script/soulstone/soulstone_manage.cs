using UnityEngine;
using System.Collections;

public class soulstone_manage : MonoBehaviour {

	public GameObject this_object;
	public GameObject temple_stone;
	public GameObject residence_stone;
	public GameObject palace_stone;
	public GameObject woodman_stone;

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
		if (temple>0)
			temple_stone.SetActive (true);
		else
			temple_stone.SetActive (false);
		if (residence>0)
			residence_stone.SetActive (true);
		else
			residence_stone.SetActive (false);
		if (palace>0)
			palace_stone.SetActive (true);
		else
			palace_stone.SetActive (false);
		if (woodman>0)
			woodman_stone.SetActive (true);
		else
			woodman_stone.SetActive (false);

	}
	public void get_soulstone(short stage,short soulstone ){
		this_object.gameObject.SetActive (true);
		if (stage == 0) {
			temple = soulstone;
			temple_stone.SetActive (true);
		} else if (stage == 1) {
			residence =soulstone;
			residence_stone.SetActive (true);
		} else if (stage == 2) {
			palace = soulstone;
			palace_stone.SetActive (true);
		} else {
			woodman =soulstone;
			woodman_stone.SetActive (true);
		}
	}
}
