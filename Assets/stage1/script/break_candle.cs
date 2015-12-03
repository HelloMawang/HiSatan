using UnityEngine;
using System.Collections;

public class break_candle : MonoBehaviour {

	public GameObject this_item;
	public GameObject breaked_candle1;
	public GameObject breaked_candle2;

	bool check = false;
	// Update is called once per frame
	void Update () {
		if(check == true)
		GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
	}
	void OnMouseEnter(){
		check = true;
	}
	void OnMouseExit(){
		check = false;
	}
	void OnMouseUpAsButton(){
		check = false;
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this_item);
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(breaked_candle1);
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(breaked_candle2);
	}

}
