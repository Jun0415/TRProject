using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	string[] messages = { "えるしっているか",
	                      "しにがみはりんごを",
	                      "りんご" };
	int messageIndex = 0;

	public GameObject imageBackground;
	public Sprite[] background = new Sprite[3];
	public GameObject buttonMessage;
	public GameObject buttonMessageText;

	public void DisplayMessage() {
		if (messages.Length <= messageIndex) {
			buttonMessage.SetActive(false);
		} else {
			buttonMessageText.GetComponent<Text>().text = messages[messageIndex];
			imageBackground.GetComponent<Image>().sprite = background[messageIndex];
			messageIndex++;
		}
	}
}