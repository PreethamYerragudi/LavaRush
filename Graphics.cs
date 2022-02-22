using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Graphics : MonoBehaviour
{
    public Color On;
    public Color Off;
    
    public TextMeshProUGUI Ok;
    public TextMeshProUGUI NotOk;
    // Start is called before the first frame update
    private void Update()
    {
        if(PlayerPrefs.GetFloat("Graphics", 0) == 0)
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
    public void ON()
    {
        Ok.color = On;
        NotOk.color = Off;
        PlayerPrefs.SetFloat("Graphics", 0);
        Debug.Log("On");
    }
    public void OFF()
    {
        Ok.color = Off;
        NotOk.color = On;
        PlayerPrefs.SetFloat("Graphics", 1);
        Debug.Log("Off");
    }
}
