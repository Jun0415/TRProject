using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour {

	public const int WALL1 = 1;
	public const int WALL2 = 2;
	public const int WALL3 = 3;
	public const int WALL4 = 4;
	public const int WALL5 = 5;

	public GameObject panelWalls;
	private int wallNo;
	public GameObject buttonMessage;
	public GameObject buttonMessageText;
	public GameObject buttonDesk1;
	public GameObject buttonDesk2;

	// Use this for initialization
	void Start () {
		wallNo = WALL1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushButtonRight() {
		wallNo++;

		if (wallNo > WALL5) {
			wallNo = WALL1;
		}
		DisplayWall();
		ClearMessages();
	}

	public void PushButtonLeft() {
		wallNo--;

		if (wallNo < WALL1) {
			wallNo = WALL5;
		}
		DisplayWall();
		ClearMessages();
	}

	public void PushButtonDesk1() {
		DisplayMessage("先輩の机だ。\n散らかっている。");
	}

	public void PushButtonDesk2() {
		DisplayMessage("部長の机だ。\n整理されている。");
	}

	public void PushButtonMessage() {
		buttonMessage.SetActive(false);
	}

	public void PushButtonLock() {
		SceneManager.LoadScene("ClearScene");
	}

	void DisplayWall() {
		switch(wallNo) {
			case WALL1:
				panelWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
				break;
			case WALL2:
				panelWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
				break;
			case WALL3:
				panelWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
				break;
			case WALL4:
				panelWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
				break;
			case WALL5:
				panelWalls.transform.localPosition = new Vector3(-4000.0f, 0.0f, 0.0f);
				break;
		}
	}

	void DisplayMessage(string mes) {
		buttonMessage.SetActive(true);
		buttonMessageText.GetComponent<Text>().text = mes;
	}

	void ClearMessages() {
		buttonMessage.SetActive(false);
	}
}
