using UnityEngine;
using System.Collections;

using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class hit_by_man : MonoBehaviour {
	public Text main_Text;
	public GameObject pantaegi;
	public GameObject carpet;

	public GameObject man;
	public GameObject back_man;
	public GameObject lying_man;
	public GameObject safe_cracker;

	public GameObject main_camera;
	public AudioSource hit_sound;

	public GameObject item_pantaegi;
	bool only_gar=false;
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 7) {
			if(!only_gar){
				if(carpet.activeSelf){}
				else{
					StartCoroutine("hitted");
					only_gar=true;
				}
			}
		}
	
	}

	IEnumerator hitted(){
		item_pantaegi.SetActive (false);
		hit_sound.Play ();
		man.SetActive(false);
		back_man.SetActive (false);
		lying_man.SetActive (false);
		string[] str={"둔탁한 소리와 \n머리를 내려치는 충격"
			,"나는 그대로 정신을 잃었다"
			,"희미한 의식너머로 \n나무꾼의 목소리가 \n들려왔다."
			,"\"네놈은 예전의 \n그 마녀와 너무 닮았어.\n 실은 내 집에 들어온\n 순간부터 기분이 더러웠다구.\""
			,"\"게다가 저 계집애를\n 잡아온 것까지 \n눈치챈 것 같더군.\n 더는 널 살려둘 이유가 없다.\""
		};

		yield return new WaitForSeconds(0.1f);
		pantaegi.SetActive(true);
		safe_cracker.SetActive(true);
		GameObject.Find("Boy").transform.position = new Vector3(51.99f,-0.8f,0f);
		main_camera.transform.position = new Vector3(51.3f,0.02f,-8.6f);
		yield return new WaitForSeconds (2f);
		for(int j=0;j<str.Length;j++){
			for (int i=0; i<=str[j].Length; i++) {
				main_Text.text = str[j].Substring(0,i);
				yield return new WaitForSeconds(0.1f);
			}
			yield return new WaitForSeconds(1f);
		}
		main_Text.text = "";
		pantaegi.SetActive(false);
		item_pantaegi.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		GameObject.Find ("Text_text").GetComponent<text_manager_woodman> ().change_sentence (1);
	}
}
