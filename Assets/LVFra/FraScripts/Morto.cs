using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morto : MonoBehaviour
{
    public GameObject haiPerso;
	public GameObject nemici;
	public GameObject muri;

	public void isHighscore()
	{
		int record = PlayerPrefs.GetInt("Highscore3");
		if (record < PlayerPrefs.GetInt("Score3"))
		{
			PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Score3"));
		}
	}


	void Update()
    {
		if (GameOver.isPlayerDead)
		{
			Time.timeScale = 0f;

			Destroy(GameObject.FindWithTag("Bullet"));
			Destroy(GameObject.FindWithTag("Enemy"));

			muri.SetActive(false);
			nemici.SetActive(false);
			isHighscore();

			haiPerso.gameObject.SetActive(true);
			
		}
	}
}
