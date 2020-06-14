using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

	private Transform enemyHolder;
	public float speed;

	public GameObject shot;
	public GameObject shot2;  //aggiunto
	public Image winText;
	public Button winButton;
	public float fireRate = 0.997f;

	//agg
	/*public Image gameOver;
	public Button gameOver1;
	public Button gameOver2;
	public static bool isPlayerDead = false;*/


	// Use this for initialization
	void Start () {

		//gameOver = GetComponent<Image>();
		//gameOver.enabled = false;

		winText.enabled = false;
		InvokeRepeating ("MoveEnemy", 0.1f, 0.3f);
		enemyHolder = GetComponent<Transform> ();
	}


	void MoveEnemy()
	{
		enemyHolder.position += Vector3.right * speed;

		foreach (Transform enemy in enemyHolder) {
			if (enemy.position.x < -2 || enemy.position.x > 2) {
				speed = -speed;
				enemyHolder.position += Vector3.down * 0.5f;
				return;
			}

			//EnemyBulletController
			if (Random.value > fireRate) {
				Instantiate (shot, enemy.position, enemy.rotation);
			}


			if (enemy.position.y <= -4) {
				GameOver.isPlayerDead = true;
				Time.timeScale = 0;
			}
		}

		if (enemyHolder.childCount == 1) {
			CancelInvoke ();  
			InvokeRepeating ("funzioneF", 0.1f, 0.2f);  //Invocare MoveEnemy

		}


		//Fatto da me
		/*if (enemyHolder.childCount == 0) {
			winText.enabled = true;
		}*/
	}

	//Funzione top
	void funzioneF()
    {
		enemyHolder.position += Vector3.right * speed;

		foreach (Transform enemy in enemyHolder)
		{
			if (enemy.position.x < -2 || enemy.position.x > 2)
			{
				speed = -speed;
				enemyHolder.position += Vector3.down * 0.5f;
				return;
			}

			//EnemyBulletController
			if (Random.value > fireRate - 0.3 )
			{
				Instantiate(shot2, enemy.position, enemy.rotation);
			}


			if (enemy.position.y <= -4)
			{
				GameOver.isPlayerDead = true;
				Time.timeScale = 0;
			}
		}

		if (enemyHolder.childCount == 0)
		{
			Destroy(GameObject.FindWithTag("Player"));

			winText.enabled = true;
			winButton.gameObject.SetActive(true);
		}


	}


}
