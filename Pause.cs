using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject Panel;
    public Color color;
    public GameObject Tut;
    public void Settings()
    {
        Panel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Unpause()
    {
        Panel.SetActive(false);
        Time.timeScale=1f;
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Shop()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Shop");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("SampleScene");
        Panel.SetActive(false);
        Time.timeScale = 1f;
        Tut.SetActive(true);
        PlayerPrefs.SetFloat("Tut",20);
        Time.timeScale = 0f;
    }
}


