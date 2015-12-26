using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class text_manager_temple : MonoBehaviour {

	private float text_delay=0.05f;
	
	public Text main_Text;
	public GameObject pantagi;
	private int num;
	private string[] data_base = {
		"여긴 이 나라에서 가장 명망이 높은 신전이다. 마침 영혼석은 저기 잘 보이는 곳에 있지만..."
		,
		"벽에 있던 그림이 벗겨져 흘러내린다"
		,
		"눈앞의 광경에 사제는 완전히 정신이 팔린 것 같다"
		,
		"얼음조각들은 사제의 몸 구석구석에 깊숙히 박혔다."
		,
		"산성용액은 사제를 녹여버렸다."
		,
		" 사제가 가져가도록 내버려두진 않겠지. 뭔가 방법이 없을까"
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
