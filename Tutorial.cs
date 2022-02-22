using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private int Num;
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Starts;
    private bool tuty = false;
    private float Countdown = 3;
    // Start is called before the first frame update
    private void Start()
    {
        Num = PlayerPrefs.GetInt("Tut", 20);
        if (Num == 20)
        {
            tuty = true;
        }
        else
        {
            tuty = false;
        }

    }
    private void Update()
    {
        Num = PlayerPrefs.GetInt("Tut", 20);
        if (tuty)
        {
            if (Num == 20)
            {
                Starts.SetActive(true);
                Time.timeScale = 0;
                Countdown -= .01f;
                Debug.Log(Countdown);
                if (Countdown <= 0)
                {
                    Starts.SetActive(false);
                    PlayerPrefs.SetInt("Tut", 0);
                }
            }
            if (Num == 0)
            {
                Countdown = 3;
                Stage1.SetActive(true);

            }
            else if (Num == 1)
            {
                Stage1.SetActive(false);
                Stage2.SetActive(true);
            }
            else if (Num == 2)
            {
                Countdown -= .01f;
                Stage2.SetActive(false);
                Stage3.SetActive(true);
                if (Countdown <= 0)
                {
                    PlayerPrefs.SetInt("Tut", 3);
                    Countdown = 3;
                }
            }
            else if (Num == 3)
            {
                Countdown -= .01f;
                Stage3.SetActive(false);
                Stage4.SetActive(true);
                if (Countdown <= 0)
                {
                    PlayerPrefs.SetInt("Tut", 4);
                    Countdown = 3;
                }
            }
            else if (Num == 4)
            {
                Time.timeScale = 1;
                gameObject.SetActive(false);
            }
        }
    }
}

    // Update is called once per frame
