using UnityEngine;
using System.Collections;

public class puzzle_manage : MonoBehaviour {

	public GameObject[] marble = new GameObject[6];
	

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

		if (GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 5 &&
			GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 4 &&
			GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 3 &&
			GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 2 &&
			GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 1 &&
			GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 0){

			GameObject.Find ("temple-soulstone").SetActive(false);
			GameObject.Find ("temple-soulstone-real").SetActive(true);
//			GameObject.Find ("EventSystem").GetComponent <move_priest>().chk=true;
			bool a = GameObject.Find ("item").GetComponent <acid_to_fountain> ().acid_chk;

			if(a == false){
				GameObject.Find ("temple-fountain top").SetActive(true);
				GameObject.Find ("temple-fountain top R").SetActive(false);
				GameObject.Find ("temple-fountain top L").SetActive(false);
				GameObject.Find ("temple-golden-water").SetActive(true);
				GameObject.Find ("temple-priest").SetActive(false);
				GameObject.Find ("temple-happy priest").SetActive(false);
			}
			else if(a == true){
				GameObject.Find ("temple-water").SetActive(true);
				GameObject.Find ("temple-priest").SetActive(false);
				GameObject.Find ("temple-melting priest").SetActive(false);
			}
			GameObject.Find ("EventSystem").GetComponent<view> ().view_change (9);
		}
	}
}
