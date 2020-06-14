using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public GameObject page;

    int m,m1;
    //int x, y;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    public TextMeshProUGUI Text;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        m = 0;
        TimerReset();
        TimerStart();
        Instantiate(page, GetRandomPosition(), Quaternion.identity);
        Instantiate(page, GetRandomPosition(), Quaternion.identity);
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
        }
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {

        timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        if (isRunning)
        {
            Text.text = (secondsInt*10).ToString();

            if (secondsInt == 5 && minutesInt == m)
            {
                Instantiate(page, GetRandomPosition(), Quaternion.identity);
                m++;
            }
            else if(secondsInt == 30 && minutesInt == m1)
            {
                Instantiate(page, GetRandomPosition(), Quaternion.identity);
                m1++;
            }
        }
    }

    public void spawn()
    {
        Instantiate(page, GetRandomPosition(), Quaternion.identity);
    }

    Vector2 GetRandomPosition()
    {
        float randomX;
        float randomY;
        do
        {
            randomX = Random.Range(minX, maxX);
            randomY = Random.Range(minY, maxY);

        } while (randomY < 1.50 && randomY > -3.50);
        return new Vector2(randomX, randomY);
    }
}
