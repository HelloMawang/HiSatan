using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager : MonoBehaviour {


	//public GUIText main_Text;

	private float text_delay=0.05f;

	public Text main_Text;
	private int num;
	private string[] data_base = {"첫번째는 지금 보고 있으신 문장입니다. and this is new line check","두번째도 지금 보고 있으신 문장입니다."};
	public void change_sentence(int num){
		this.num = num;
		StopCoroutine ("change_sentence_order");
		StartCoroutine ("change_sentence_order");
	}
	IEnumerator change_sentence_order(){
		for (int i=0; i<=data_base[num].Length; i++) {
			main_Text.text = data_base[num].Substring(0,i);
			yield return new WaitForSeconds(text_delay);
		}
	}

	void Start(){
		change_sentence (0);
	}
}
