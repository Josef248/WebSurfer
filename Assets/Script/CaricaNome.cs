using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CaricaNome : MonoBehaviour
{
    public TextMeshProUGUI nameBox;

    void Start()
    {
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
    }

    void Update()
    {
        nameBox.text = PlayerPrefs.GetString("NamePlayer");
    }


}
