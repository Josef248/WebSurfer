using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaricaScene : MonoBehaviour
{
    public void openMap()
    {
        SceneManager.LoadScene("Mappa");
    }

    public void scenaC2()
    {
        SceneManager.LoadScene("SpiegazioneConcetto2");
    }


}
