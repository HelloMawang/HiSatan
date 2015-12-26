using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager_residence : MonoBehaviour {
	
	
	//public GUIText main_Text;
	
	private float text_delay=0.05f;
	public GameObject pantaegi;
	public Text main_Text;
	private int num;
	private string[] data_base = {"저 아이 목에 걸린 건 분명 마정석이다. 저걸 꼭 얻어야 하는데"
		,
		"저택이 붕괴하면 근방의 사람들은 모두 무사하지 못하겠지."
		,
		" 이 집은 기둥 하나만 망가져도 무너져 내릴 것 같다."
		,
		"저택의 곳곳에서 균열이 일어난다. 바닥과 지붕이 흔들린다."
		,
		"도끼가 너무 불안정해"
		,
		"도끼의 손잡이는 이미 못쓸정도로 부러졌다."
	};
	public void change_sentence(int number){
		num = number;
		StopCoroutine ("change_sentence_order");
		StartCoroutine ("change_sentence_order");
	}
	IEnumerator change_sentence_order(){
		pantaegi.SetActive (true);
		for (int i=0; i<=data_base[num].Length; i++) {
			main_Text.text = data_base[num].Substring(0,i);
			yield return new WaitForSeconds(text_delay);
		}
		yield return new WaitForSeconds (2f);
		pantaegi.SetActive (false);
		main_Text.text = "";
	}
	
	void Start(){
		change_sentence (0);
	}
}