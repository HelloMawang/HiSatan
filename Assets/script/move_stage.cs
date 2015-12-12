using UnityEngine;
using System.Collections;

public class move_stage : MonoBehaviour {


	public GameObject main_camera;
	public GameObject player;

	public int[] change_position;

	public Vector3[] camera_position ;
	public Vector3[] goto_player_position;
	public void camera_change(int player_position){

		for(int i=0;i<change_position.Length;i++){
			if(player_position == change_position[i]){
				main_camera.transform.position = camera_position[i];
				player.transform.position = goto_player_position[i];
			}
		}

	}
}
