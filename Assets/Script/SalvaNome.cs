using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SalvaNome : MonoBehaviour
{
    public InputField textBox;

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("NamePlayer", textBox.text);
        Debug.Log("Il nome del giocatore: " + PlayerPrefs.GetString("NamePlayer"));
    }
}
