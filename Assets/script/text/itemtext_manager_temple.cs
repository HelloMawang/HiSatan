using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class itemtext_manager_temple : MonoBehaviour {

	public GameObject panel;
	public Text item_text;
	public GameObject main_camera;
	// Use this for initialization
	string[] data_base = {"부식성 용액이 담긴 병"
		,
		"벽 따위를 청소할 때 쓰인 것 같다"
	};
	
	void Start(){
	}
	
	public void item_info_set(int num,Vector3 item_pos){
		item_text.text = data_base [num];
	}
	public void item_info_off(){
		
		item_text.text = "";
	}
}
