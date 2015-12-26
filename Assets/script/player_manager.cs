using UnityEngine;
using System.Collections;

public class player_manager : MonoBehaviour {

	public int use_devil=0;


	public bool is_devil =false;
	public bool std=false;
	public bool BW=false;
	public bool SW=false;
	public bool FD=false;
	public bool PD=false;

	public GameObject boy_std;
	public GameObject boy_BW;
	public GameObject boy_SW;
	public GameObject boy_FD;
	public GameObject boy_PD;

	public bool can_change = false;

	public void set_player(){
		std = true;
		if (std == true)
			boy_std.SetActive (true);
		else
			boy_std.SetActive (false);
		if (BW == true)
			boy_BW.SetActive (true);
		else
			boy_BW.SetActive (false);
		if (SW == true)
			boy_SW.SetActive (true);
		else
			boy_SW.SetActive (false);
		if (FD == true)
			boy_FD.SetActive (true);
		else
			boy_FD.SetActive (false);
		if (PD == true)
			boy_PD.SetActive (true);
		else
			boy_PD.SetActive (false);


	}

	public void devil_change(){
		if (can_change) {
			if (use_devil == 0) {
				if (std == true) {
					PD = true;
					std = false;
				} else { //(PD==true)
					PD = false;
					std = true;
				}
			} else if (use_devil == 1) {
				if (PD == true) {
					PD = false;
					SW = true;
				} else if (SW == true) {
					SW = false;
					FD = true;
				} else { //FD==true
					FD = false;
					SW = true;
				}
			} else { // use_devil>=2
				if(SW==true){
					SW= false;
					FD=true;
				}
				if (FD == true) {
					FD = false;
					BW = true;
				} else {//BW==true
					BW = false;
					FD = true;
				}
			}


			if (std == true){
				boy_std.SetActive (true);
				is_devil=false;
			}
			else if (std == false)
				boy_std.SetActive (false);
			if (BW == true){
				boy_BW.SetActive (true);
				is_devil=false;
			}
			else if (BW == false)
				boy_BW.SetActive (false);
			if (SW == true){
				boy_SW.SetActive (true);
				is_devil=false;
			}
			else
				boy_SW.SetActive (false);
			if (FD == true){
				boy_FD.SetActive (true);
				is_devil=true;
			}
			else
				boy_FD.SetActive (false);
			if (PD == true){
				boy_PD.SetActive (true);
				is_devil=true;
			}
			else if (PD == false)
				boy_PD.SetActive (false);
		}
	}
}
