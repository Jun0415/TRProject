using System.Collections;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour {

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	private string[] messages = { "あれ……ここは……",
						  "あぁ、そうか……部長に残業を頼まれて",
						  "……そろそろ家へ帰るか" };
	private int messageIndex = 0;

	public GameObject buttonMessage;
	public GameObject buttonMessageText;
	public GameObject panel;

	public void DisplayMessage() {
		if (messages.Length <= messageIndex) {
			SceneManager.LoadScene("GameScene");
		} else {
			buttonMessageText.GetComponent<Text>().text = messages[messageIndex];
			Debug.Log(panel.GetComponent<Image>().color.a);
			panel.GetComponent<Image>().color = new Color(0f, 0f, 0f, panel.GetComponent<Image>().color.a * 0.65f);
			messageIndex++;
		}
	}
}