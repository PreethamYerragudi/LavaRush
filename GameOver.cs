using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOver : MonoBehaviour
{
    public GameObject Button;
    public GameObject Button2;
    private void Update()
    {
        if (PlayerPrefs.GetInt("Music", 0) == 1)
        {
            Button.SetActive(false);
            Button2.SetActive(true);
        }
        else
        {
            Button.SetActive(true);
            Button2.SetActive(false);
        }
              
    }
    public void BringTheFire()
    {
        PlayerPrefs.SetInt("Music", 1);
        Button.SetActive(false);
        Button2.SetActive(true);
    }
    public void KillTheMockingbird()
    {
        PlayerPrefs.SetInt("Music", 0);
        Button.SetActive(true);
        Button2.SetActive(false);
    }
}
