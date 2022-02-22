using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("yes", 0);
    }
    // Start is called before the first frame update
    public void PlayButton()
    {
        PlayerPrefs.SetInt("$", PlayerPrefs.GetInt("$", 0) + 1);
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("yes", 1);
    }
}
