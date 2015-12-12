using UnityEngine;
using System.Collections;

public class view : MonoBehaviour {
	
	
	public GameObject main_camera;
	public GameObject player;
	
	public int[] change_scene = new int[2];
	
	public Vector3[] camera_position = new Vector3[2];
	public void view_change(int player_position){
		
		for(int i=0;i<4;i++){
			if(player_position == change_scene[i]){
				main_camera.transform.position = camera_position[i];
			}
		}
		
	}
}

