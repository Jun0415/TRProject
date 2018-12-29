using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private string[] messages = { "やった！ やっと出られたぞ！",
						  "これで家に帰れ……って、もう6時か",
						  "……出社しよう。今日も仕事頑張ろう……" };
	private int messageIndex = 0;

	public GameObject buttonMessage;
	public GameObject buttonMessageText;
	public GameObject button;
	public GameObject buttonReturn;

	public void init() {
		button.SetActive(false);
		buttonMessage.SetActive(true);
		DisplayMessage();
	}

	public void DisplayMessage() {
		if (messages.Length <= messageIndex) {
			buttonMessage.SetActive(false);
			buttonReturn.SetActive(true);
//			SceneManager.LoadScene("GameScene");
		} else {
			buttonMessageText.GetComponent<Text>().text = messages[messageIndex];
			messageIndex++;
		}
	}

	public void ReturnToTitle() {
		SceneManager.LoadScene("TitleScene");
	}
}
