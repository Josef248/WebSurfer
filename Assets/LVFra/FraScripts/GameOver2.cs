using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameOver1 : MonoBehaviour
{

	public static bool isPlayerDead = false;

	private Button gameOver;


	void Start()
	{
		gameOver = GetComponent<Button>();
		gameOver.enabled = false;
	}

	void Update()
	{
		if (isPlayerDead)
		{
			Time.timeScale = 0;
			gameOver.enabled = true;
		}
	}
}