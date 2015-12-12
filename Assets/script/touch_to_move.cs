using UnityEngine;
using System.Collections;

public class touch_to_move : MonoBehaviour {
	
	public GameObject player;
	
	public int its_location;
	
	void OnMouseUpAsButton() {
		
		Vector3 direction = (this.gameObject.transform.position + new Vector3(0.5f,2f,0f)-player.transform.position  ); 
		
		float dis = direction.magnitude;
		if (dis > 0.1f) {
			GameObject.Find ("Boy").GetComponent<player_state> ().walk (direction.normalized, dis, its_location);
		}
	}
}