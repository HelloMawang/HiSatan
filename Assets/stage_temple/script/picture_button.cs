using UnityEngine;
using System.Collections;

public class picture_button : MonoBehaviour {

	public GameObject cursor_hand;
	public GameObject picture;
	
	void OnMouseUpAsButton(){
		
		Cursor.visible = true;
		cursor_hand.SetActive (false);

		picture.GetComponent <picture_touch>().button();
	}
}
