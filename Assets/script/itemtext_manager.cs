using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class itemtext_manager : MonoBehaviour {

	public GameObject panel;
	public Text item_text;
	public GameObject main_camera;
	// Use this for initialization
	string[] data_base = {"axe","chicken","bracnh","matchbox","candle"+"\n"+"new line text"};

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
