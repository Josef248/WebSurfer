using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	private Transform bullet;
	public float speed;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Transform> ();
	}

	void FixedUpdate(){
		bullet.position += Vector3.up * speed;

		if (bullet.position.y >= 5)
			Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Enemy") {

			int puntiOra = PlayerPrefs.GetInt("Score3");
			puntiOra += 10;
			PlayerPrefs.SetInt("Score3", puntiOra);
			
			Destroy (other.gameObject);
			Destroy(gameObject);



			//Score.punteggioInt += 10;n
		}
		else if (other.tag == "Base")
			Destroy (gameObject);


	}
}
