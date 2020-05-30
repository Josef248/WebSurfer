using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SalvaNome : MonoBehaviour
{
    public InputField textBox;
    public TextMeshProUGUI nameBox;

    
    void Start()
    {
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
    }


    public void clickSaveButton()
    {
        PlayerPrefs.SetString("NamePlayer", textBox.text);
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
        Debug.Log("Il nome del giocatore: " + PlayerPrefs.GetString("NamePlayer"));
    }

    public void resetSavedGame()
    {
        PlayerPrefs.DeleteKey("NamePlayer");
        //SceneManager.LoadScene("Other");

    }


    /*
     * 
     * Controlla se il nome iniziale del player è: Ospite1234
     * 
    public bool firstNamePlayer()
    {
        System.String namePlayer = PlayerPrefs.GetString("NamePlayer");
        if (namePlayer.Equals("Ospite1234")){

            return false;
        }
        else
        {
            return true;
        }
    }
    */
        




}
