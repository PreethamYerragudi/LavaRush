using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    public float CoinTotal;
    public PlayerMovement Dist;
    public TextMeshProUGUI Text;
    private Shop Sho;
    // Start is called before the first frame update
    void Start()
    {
        Text.text = "High Score: "+PlayerPrefs.GetFloat("HighScore", 0).ToString();
        
    }

    // Update is called once per frame
    void Update()
        { 
        if (Dist.distance > PlayerPrefs.GetFloat("HighScore",0))
        {
            PlayerPrefs.SetFloat("HighScore", Dist.distance);
            Text.text ="High Score: " + Dist.distance.ToString();
        }
        
    }
}
