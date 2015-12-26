using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class itemtext_manager_woodman : MonoBehaviour {
	
	public GameObject panel;
	public Text item_text;
	// Use this for initialization
	string[] data_base = {"큼지막한 몽둥이. 여기에 맞는다면 한 방에 기절할지도 모르겠다"
		,
		"불이 붙은 장작. 다른 곳에 옮겨 붙일 수 있을 것 같다"
		,
		"나무꾼이 애지중지 하는 조각상"
		
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