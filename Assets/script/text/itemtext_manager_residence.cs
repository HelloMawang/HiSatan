using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class itemtext_manager_residence : MonoBehaviour {
	
	public GameObject panel;
	public Text item_text;
	// Use this for initialization
	string[] data_base = {"흔한 나무막대. 자체만으로는 별 쓰임새가 없는 듯 하다."
		,
		"한 손으로 휘두르기 알맞은 도끼. 장작을 팰 때 쓰던 것"
		,
		"떨어져 나온 도끼 날"
		,
		"날이 잘 드는 가위. 두꺼운 천도 한번에 자를 수 있을 것 같다"
		,
		"너무 약해서 도끼로 쓰기엔 부적합하다. 맬 수 있는 천 같은 게 있었으면.."
		,
		"커텐을 자른 것. 단단히 잡아매는데 좋을 것 같다."
		,
		"이 도끼라면 충분해보인다."
		,

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