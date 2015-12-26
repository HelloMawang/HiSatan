using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager : MonoBehaviour {


	//public GUIText main_Text;

	private float text_delay=0.05f;

	public Text main_Text;
	public GameObject pantagi;
	private int num;
	private string[] data_base = {" 분명 그를 불러낼 수 있는 방법이 있을거야"
		,
		" 불길은 삽시간에 짚단을 삼켜버렸다"
		,
		" 나를 불러낸 것이 너로구나. 너의 의지를 내가 돕겠다. 나를 받아들여라."
	};
	public void change_sentence(int number){
		num = number;
		StopCoroutine ("change_sentence_order");
		StartCoroutine ("change_sentence_order");
	}
	IEnumerator change_sentence_order(){
		pantagi.SetActive (true);
		for (int i=0; i<=data_base[num].Length; i++) {
			main_Text.text = data_base[num].Substring(0,i);
			yield return new WaitForSeconds(text_delay);
		}
		yield return new WaitForSeconds (2f);
		pantagi.SetActive (false);
		main_Text.text = "";
	}

	void Start(){
		change_sentence (0);
	}
}
