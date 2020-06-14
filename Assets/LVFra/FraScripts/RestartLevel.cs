using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

	int puntiOra;
	//int puntiOra = PlayerPrefs.GetInt("HighScore");
	//private Button Win; //agg

	//Update is called once per frame

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {

			//Win = GetComponent<Button>();
			//Win.enabled = true;

			puntiOra = 0;
			//PlayerPrefs.SetInt("HighScore", punteggioInt + puntiOra);

			//PlayerScore.playerScore = 0;
			GameOver.isPlayerDead = false;
			Time.timeScale = 1;

			SceneManager.LoadScene ("Mappa");
		}
	}

	/*
	void Update()
	{
		if (Input.GetButton("Next"))
		{
			puntiOra = 0;

			//PlayerScore.playerScore = 0;
			GameOver.isPlayerDead = false;
			Time.timeScale = 1;

			SceneManager.LoadScene("Mappa");
		}
	}*/


}
