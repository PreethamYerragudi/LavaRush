using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{

    // Start is called before the first frame update
    public void Shoper()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Pong()
    {
        PlayerPrefs.SetInt("Tut", 20);
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("yes", 1);
    }
}
