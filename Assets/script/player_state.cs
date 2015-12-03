using UnityEngine;
using System.Collections;

public class player_state : MonoBehaviour {

	private Vector3 player_vector;
	private float time_to_walk;
	private float walk_speed = 5f;

	public int his_position = 0;
	public int there_position;
	public Animator anima;

	bool is_Rotate= false;

	public void walk(Vector3 p_vector,float dis,int its_location){
		StopCoroutine ("do_walk");
		if (p_vector.x < 0 && is_Rotate == false) {
			gameObject.transform.Rotate (new Vector3 (0f, 180f, 0f));
			is_Rotate = true;
		} else if (p_vector.x > 0 && is_Rotate == true) {
			gameObject.transform.Rotate (new Vector3 (0f, 180f, 0f));
			is_Rotate = false;
		}
		there_position = its_location;
		player_vector = p_vector;
		if(is_Rotate==true) {
			player_vector.x = -player_vector.x;
			player_vector.z = -player_vector.z;
		}
		time_to_walk = dis/walk_speed;
		StartCoroutine ("do_walk");

	}
	public IEnumerator do_walk (){
		int frame = 50;
		anima.SetBool ("walk", true);
		for (int i=0; i<time_to_walk*frame; i++) {

			gameObject.transform.Translate (player_vector * (walk_speed/frame) );
			yield return new WaitForSeconds(1f/frame); 
		}
		his_position = there_position;
		GameObject.Find ("EventSystem").GetComponent<move_stage> ().camera_change (his_position);
		anima.SetBool ("walk",false);
	}
}
