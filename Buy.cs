using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    private float coins;
    public GameObject Bought;
    public int Price;
    public int Number;
    public bool Wood;
    public bool Eye;
    public bool Face;
    public bool Ball;
    public bool Glass;
    public bool Leather;
    // Start is called before the first frame update
    void Update()
    {
            coins = PlayerPrefs.GetFloat("Coins");
        if (Wood)
        {
            if (PlayerPrefs.GetInt("Wood", 0) == 1)
            {
                gameObject.SetActive(false);
 
            }
        }
        if (Eye)
        {
            if (PlayerPrefs.GetInt("Eye", 0) == 1)
            {
                gameObject.SetActive(false);

            }
        }
        if (Face)
        {
            if (PlayerPrefs.GetInt("Face", 0) == 1)
            {
                gameObject.SetActive(false);
            }
        }
        if (Ball)
        {
            if (PlayerPrefs.GetInt("Ball", 0) == 1)
            {
                gameObject.SetActive(false);
            }
        }
        if (Glass)
        {
            if (PlayerPrefs.GetInt("Glass", 0) == 1)
            {
                gameObject.SetActive(false);
            }
        }
        if (Leather)
        {
            if (PlayerPrefs.GetInt("Leather", 0) == 1)
            {
                gameObject.SetActive(false);
                
            }
        }
    }
    // Update is called once per frame
    public void TeeHee()
    {
        if (coins >= Price)
        {
            PlayerPrefs.SetFloat("Coins", coins - Price);
            gameObject.SetActive(false);
            PlayerPrefs.SetFloat("Skin", Number);
            if (Wood)
            {
                PlayerPrefs.SetInt("Wood", 1);
            }else if (Eye)
            {
                PlayerPrefs.SetInt("Eye", 1);
            }
            else if (Face)
            {
                PlayerPrefs.SetInt("Face", 1);
            }
            else if (Ball)
            {
                PlayerPrefs.SetInt("Ball", 1);
            }
            else if (Glass)
            {
                PlayerPrefs.SetInt("Glass", 1);
            }
            else if (Leather)
            {
                PlayerPrefs.SetInt("Leather", 1);
            }
        }
    }
}
