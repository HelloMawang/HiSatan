using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class itemtext_manager : MonoBehaviour {

	public GameObject panel;
	public Text item_text;
	public GameObject main_camera;
	// Use this for initialization
	string[] data_base = {"긴 양초. 이대로 쓰기에는 뭔가 애매한데","성냥. 딱 세 개비만 들어있다.","더 이상은 너를 지켜줄 수 없을 것 같아. 미안."
		,"너의 희생은 잊지 않을게","도끼는 여러 번 휘둘러서는 안 된다. 단 한번 휘둘러서 끝내야 해","양초."
		,"기다란 작대기. 높은 곳에 있는 것들을 건드릴 수 있을 것 같다."
	};

	void Start(){
		panel.transform.position = new Vector3(0f,0f,0f);
	}

	public void item_info_set(int num,Vector3 item_pos){
		item_text.text = data_base [num];
		panel.transform.position = (main_camera.transform.position)+new Vector3(0f,550f,0f);
	}
	public void item_info_off(){
		panel.transform.position = new Vector3(0f,0f,0f);
	}
}
