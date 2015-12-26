using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager_final : MonoBehaviour {

	private float text_delay=0.05f;
	
	public Text main_Text;
	public GameObject pantagi;
	private int num;
	private string[] data_base = {"",
		" 석상은 순간 빛이 나고 가루가 되어 흩어졌다"
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
