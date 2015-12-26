using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager_woodman : MonoBehaviour {
	
	
	//public GUIText main_Text;
	
	private float text_delay=0.05f;
	public GameObject pantaegi;
	public Text main_Text;
	private int num;
	private string[] data_base = {"영혼석은 이 집 어딘가에 있을 것이다. 저 나무꾼이라면 어디 있는지 알겠지"
		,
		"여기서 당장 나가야해"
		,
		"튀어나온 철제이음새 모서리에 줄이 걸렸던 모양이다"
		,
		"쉽게 끊어졌다"
		,
		"금세 따라 잡히고 말 것 같다. 어떻게든 하지 않으면...."
		,
		"나무꾼의 비명소리와 살이 타는 냄새가 난다"
		,
		"여긴 뭐지. 어떻게 된건지 물어봐야겠어."
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

}