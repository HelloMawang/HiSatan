using UnityEngine;
using System.Collections;

public class move_stage : MonoBehaviour {


	public GameObject main_camera;
	public GameObject player;

	public int[] change_position = new int[7];

	public Vector3[] camera_position = new Vector3[7];
	public Vector3[] goto_player_position = new Vector3[7];
	public void camera_change(int player_position){

		for(int i=0;i<7;i++){
			if(player_position == change_position[i]){
				main_camera.transform.position = camera_position[i];
				player.transform.position = goto_player_position[i];
			}
		}

	}
}
