using UnityEngine;
using System.Collections;

public class puzzle_manage : MonoBehaviour {

	public GameObject[] marble = new GameObject[6];

	public GameObject temple_fountain_top;
	public GameObject temple_fountain_top_R;
	public GameObject temple_fountain_top_L;
	public GameObject temple_golden_water;
	public GameObject temple_priest;
	public GameObject temple_happy_priest;
	public GameObject temple_water;
	public GameObject temple_melting_priest;
	public void change_marble(GameObject input_marble){
		if (input_marble == marble [0]) {
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [1]) {
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [2]) {
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [3]) {
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [4]) {
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [5]) {
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
		}

		if ((GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 5 &&
			GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 4 &&
			GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 3 &&
			GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 2 &&
			GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 1 &&
			GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 0)
		    ||(GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 4 &&
		   GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 3 &&
		   GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 2 &&
		   GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 1 &&
		   GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 0 &&
		   GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 5)
		    ||(GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 3 &&
		   GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 2 &&
		   GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 1 &&
		   GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 0 &&
		   GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 5 &&
		   GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 4)
		    ||(GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 2 &&
		   GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 1 &&
		   GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 0 &&
		   GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 5 &&
		   GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 4 &&
		   GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 3)
		    ||(GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 1 &&
		   GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 0 &&
		   GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 5 &&
		   GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 4 &&
		   GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 3 &&
		   GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 2)
		    ||(GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 0 &&
		   GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 5 &&
		   GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 4 &&
		   GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 3 &&
		   GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 2 &&
		   GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 1)){

			GameObject.Find ("temple-soulstone").GetComponent<can_get_soulstone>().change_stone();
//			GameObject.Find ("EventSystem").GetComponent <move_priest>().chk=true;
			bool a = GameObject.Find ("bottle_Area").GetComponent <acid_to_fountain> ().acid_chk;

			if(a == false){
				temple_fountain_top.SetActive(true);
				temple_fountain_top_R.SetActive(false);
				temple_fountain_top_L.SetActive(false);
				temple_golden_water.SetActive(true);
				temple_priest.SetActive(false);
				temple_happy_priest.SetActive(true);
				GameObject.Find ("Text_text").GetComponent<text_manager_temple> ().change_sentence (2);
			}
			else if(a == true){
				temple_water.SetActive(true);
				temple_priest.SetActive(false);
				temple_melting_priest.SetActive(true);
				GameObject.Find ("Text_text").GetComponent<text_manager_temple> ().change_sentence (4);
			}
			GameObject.Find ("EventSystem").GetComponent<view> ().view_change (9);
		}
	}
}
