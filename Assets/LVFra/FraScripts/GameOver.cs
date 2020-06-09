using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public static bool isPlayerDead = false;

	private Image gameOver; 
	public Button gameOver1;
	//private Text gameOver2;

	void Start () {
		gameOver = GetComponent<Image> ();
		gameOver.enabled = false;
		/*gameOver1 = GetComponent<Button>();
		gameOver1.enabled = false;
		gameOver2 = GetComponent<Text>();
		gameOver2.enabled = false;*/
	}

	void Update () {
		if (isPlayerDead) {
			Time.timeScale = 0;
			gameOver.enabled = true;
			//gameOver1.enabled = true;
			//gameOver2.enabled = true;

			gameOver1.gameObject.SetActive(true);
		}
	}


	/*private GameObject gameOver;

	void Start()
    {
		gameOver.SetActive(false);
    }

	void Update()
	{
		if (isPlayerDead)
		{
			Time.timeScale = 0;
			gameOver.SetActive(true);
		}
	}*/
}
