using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class text_manager_woodman : MonoBehaviour {
	
	
	//public GUIText main_Text;
	
	private float text_delay=0.05f;
	
	public Text main_Text;
	private int num;
	private string[] data_base = {"영혼석은 이 집 어딘가에 있을 것이다. 저 나무꾼이라면 어디 있는지 알겠지"
		,
		"네놈은 예전의 그 마녀와 너무 닮았어. 실은 내 집에 들어온 순간부터 기분이 더러웠다구"
		,
		"게다가 저 계집애를 잡아온 것까지 눈치챈 것 같더군. 더는 널 살려둘 이유가 없다"
		,
		"여기서 당장 나가야해"
		,
		"금세 따라 잡히고 말 것 같다. 어떻게든 하지 않으면...."
		,
		"나무꾼의 비명소리와 살이 타는 냄새가 난다"
	};
	public void change_sentence(int number){
		num = number;
		StopCoroutine ("change_sentence_order");
		StartCoroutine ("change_sentence_order");
	}
	IEnumerator change_sentence_order(){
		for (int i=0; i<=data_base[num].Length; i++) {
			main_Text.text = data_base[num].Substring(0,i);
			yield return new WaitForSeconds(text_delay);
		}
		yield return new WaitForSeconds (2f);
		main_Text.text = "";
	}

}