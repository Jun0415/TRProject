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
	public const int MEMO_ID = 0;
	public const int BOOK_ID = 1;
	public const int FLOWER_ID = 2;

	public Sprite[] items = new Sprite[3];
	public GameObject panelWalls;
	private int wallNo;
	public GameObject buttonMessage;
	public GameObject buttonMessageText;
	public GameObject buttonDesk1;
	public GameObject buttonDesk2;
	public GameObject imageDesk1;
	public GameObject buttonMemo;
	public GameObject buttonBook;
	public GameObject buttonFlower;
	public GameObject buttonIcon1;
	public GameObject buttonIcon2;
	public GameObject buttonIcon3;
	public GameObject buttonCloseUp;
	public GameObject buttonWall;
	public GameObject[] switches = new GameObject[3];
	public Sprite switch_on;
	public InputField[] answers = new InputField[3];

	private bool doesHaveQ3 = false;

	// Use this for initialization
	void Start () {
		wallNo = WALL2;
		DisplayWall();
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
		ClearButtonCloseUp();
	}

	public void PushButtonLeft() {
		wallNo--;

		if (wallNo < WALL1) {
			wallNo = WALL5;
		}
		DisplayWall();
		ClearMessages();
		ClearButtonCloseUp();
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

	public void PushButtonMemo() {
		buttonMemo.SetActive(false);
		CloseUpItem(MEMO_ID);
		buttonIcon1.SetActive(true);
		DisplayMessage("メモ取得時メッセージ");
	}

	public void PushButtonBook() {
		buttonBook.SetActive(false);
		CloseUpItem(BOOK_ID);
		buttonIcon2.SetActive(true);
		DisplayMessage("BOOK取得時メッセージ");
	}

	public void PushButtonFlower()　{
		if (doesHaveQ3 == false) {
//			buttonFlower.SetActive(false);
			CloseUpItem(FLOWER_ID);
			buttonIcon3.SetActive(true);
			DisplayMessage("FLOWER取得時メッセージ");
			doesHaveQ3 = true;
		}
	}

	public void ClearButtonCloseUp() {
		buttonCloseUp.SetActive(false);
		buttonWall.SetActive(false);
		ClearMessages(); //////////汚いから後で直す。
	}

	public void CloseUpItem(int itemID) {
		buttonCloseUp.GetComponent<Image>().sprite = items[itemID];
		buttonCloseUp.SetActive(true);
		buttonWall.SetActive(true);
	}

	public void PushButtonWall() {

	}

	public void CheckAnswer(int index) {
		string ans = answers[index].GetComponent<InputField>().text.ToString();
		Debug.Log(ans);
		switch (index) {
			case 0:
				if (ans.Equals("98")) {
					switches[index].GetComponent<Image>().sprite = switch_on;
				}
				break;
			case 1:
				if (ans.Equals("60")) {
					switches[index].GetComponent<Image>().sprite = switch_on;
				}
				break;
			case 2:
				if (ans.Equals("36")) {
					switches[index].GetComponent<Image>().sprite = switch_on;
				}
				break;
		}
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

	void DisplayInitalMessage() {
		string[] messages = {"", "", ""};
		buttonMessage.SetActive(true);
		buttonMessageText.GetComponent<Text>().text = messages[0];
	}

	void ClearMessages() {
		buttonMessage.SetActive(false);
	}
}
