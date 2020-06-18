using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScaleTween : MonoBehaviour
{
    public UnityEvent onCompleteCallback;
    public int punteggioInt = 10;

    public void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.3f).setDelay(0.1f).setOnComplete(OnComplete);
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
        //LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setDelay(0.5f).setOnComplete(DestroyMe);
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
        //LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f);
        countLink();

    }


    public void DestroyMe()
    {
        Destroy(gameObject);
        //DestroyImmediate(gameObject, true);
    }

    public void countLink()
    {
        int linkOra = PlayerPrefs.GetInt("numeroLink");
        linkOra++;
        PlayerPrefs.SetInt("numeroLink", linkOra);

    }


    public void SaliPunteggio()
    {
        int puntiOra = PlayerPrefs.GetInt("Score1");
        PlayerPrefs.SetInt("Score1", punteggioInt + puntiOra);

    }


}
