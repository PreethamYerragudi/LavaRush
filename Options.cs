using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Options : MonoBehaviour
{
    public Color On;
    public Color Off;

    public TextMeshProUGUI Ok;
    public TextMeshProUGUI NotOk;
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Options")
        {
            if (PlayerPrefs.GetFloat("Difficulty", 0) == 0)
            {
                Ok.color = On;
                NotOk.color = Off;
            }
            else
            {
                Ok.color = Off;
                NotOk.color = On;
            }
        }

    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Easy()
    {
        Ok.color = On;
        NotOk.color = Off;
        PlayerPrefs.SetFloat("Difficulty", 0);
        Debug.Log("On");
    }
    public void Hard() {
        Ok.color = Off;
        NotOk.color = On;
        PlayerPrefs.SetFloat("Difficulty", 1);
    }

}
