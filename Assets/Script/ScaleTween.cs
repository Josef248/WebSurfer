using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScaleTween : MonoBehaviour
{
    //public Text punteggio;
    public UnityEvent onCompleteCallback;
    public int punteggioInt = 10;

    public void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.3f).setDelay(0.2f).setOnComplete(OnComplete);
    }

    public void OnComplete()
    {
        if(onCompleteCallback != null)
        {
            onCompleteCallback.Invoke();
        }
    }

    public void OnClose()
    {
        SaliPunteggio();
        //LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f);
        countLink();

    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }

    public void Invisible()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void countLink()
    {
        int linkOra = PlayerPrefs.GetInt("numeroLink");
        linkOra++;
        PlayerPrefs.SetInt("numeroLink", linkOra);

        ///Debug.Log("Numero link chiusi : " + linkOra);
    }


    public void SaliPunteggio()
    {
        int puntiOra = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.SetInt("HighScore", punteggioInt + puntiOra);
        //punteggio.text = PlayerPrefs.GetInt("HighScore").ToString();

        //Debug.Log("X premuta, punteggio totale = " + (punteggioInt + puntiOra));
    }


}
