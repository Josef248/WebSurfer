using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class ReloadScene : MonoBehaviour
{


    public Image gameOver;
    public Button gameOver1;
    public Button gameOver2;

    //int puntiOra;

    // Start is called before the first frame update
    void Start()
    {
        //gameOver = GetComponent<Image>();
        //gameOver.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadCurrent()
    {

        //puntiOra = 0;

        GameOver.isPlayerDead = false;
        Time.timeScale = 1;

        SceneManager.LoadScene("lv3");

        Time.timeScale = 1;
        gameOver.enabled = false;
        gameOver1.gameObject.SetActive(false);
        gameOver2.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
