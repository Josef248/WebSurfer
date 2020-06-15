using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SalvaNome : MonoBehaviour
{

    public InputField textBox;
    public TextMeshProUGUI nameBox;


    void Start()
    {
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
    }


    public void salvaNome()
    {
        PlayerPrefs.SetString("NamePlayer", textBox.text);
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
        Debug.Log("Il nome del giocatore: " + PlayerPrefs.GetString("NamePlayer"));
    }



}
