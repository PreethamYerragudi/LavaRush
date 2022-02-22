using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Buying : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Tier1Obj;
    public GameObject Tier2Obj;
    public GameObject Tier3Obj;
    public GameObject FinishedObj;
    public float coins;
    private bool Tier1=true;
    private bool Tier2=false;
    private bool Tier3=false;
    private int Price;
    public int Price1;
    public int Price2;
    public int Price3;
    public int GunTier;
    public bool Gun;
    public bool Bullet;
    public TextMeshProUGUI CoinText;
    // Start is called before the first frame update
    private void Start()
    {
        Price =Price1;
        Text.text = "BUY:$" + Price.ToString();
        if (Bullet)
        {
            if (PlayerPrefs.GetFloat("Bullet", 0) == 1)
            {
                Tier1Obj.SetActive(false);
                Tier1 = false;
                Tier2 = true;
                Price = Price2;
                Text.text = "BUY:$" + Price.ToString();
            }
            else if (PlayerPrefs.GetFloat("Bullet", 0) == 2)
            {
                Tier2Obj.SetActive(false);
                Tier2 = false;
                Tier3 = true;
                Price = Price2;
                Text.text = "BUY:$" + Price.ToString();
            }
            else if (PlayerPrefs.GetFloat("Bullet", 0) == 3)
            {
                Tier3Obj.SetActive(false);
                Tier3 = false;
                Text.text = "BOUGHT";
            }
        }
        if (Gun)
        {

            if (PlayerPrefs.GetFloat("Guns", 0) == 1)
            {
                Tier1Obj.SetActive(false);
                Tier1 = false;
                Tier2 = true;
                Price = Price2;
            }
            else if (PlayerPrefs.GetFloat("Guns", 0) == 2)
            {
                Tier2Obj.SetActive(false);
                Tier2 = false;
                Tier3 = true;
                Price = Price2;
            }
            else if (PlayerPrefs.GetFloat("Guns", 0) == 3)
            {
                Tier3Obj.SetActive(false);
                Tier3 = false;
                Text.text = "BOUGHT";
            }
        }
    }
    private void Update()
    {
        coins = PlayerPrefs.GetFloat("Coins");
        CoinText.text = coins.ToString();
    }
    // Update is called once per frame
    public void ChickenNoodleSoup()
    {
        
        if (Tier1)
        {
            
            if (coins >= Price1)
            {
                if (Gun)
                {
                    PlayerPrefs.SetFloat("Guns", 1);
                }
                else if (Bullet)
                {
                    PlayerPrefs.SetFloat("Bullet", 1);
                }
                PlayerPrefs.SetFloat("Coins", coins - Price1);
                Tier1Obj.SetActive(false);
                Tier1 = false;
                Tier2 = true;
                Price = Price2;
                Text.text = "BUY:$" + Price.ToString();
            }
        }else if (Tier2)
        {
            if (coins >= Price2)
            {
                if (Gun)
                {
                    PlayerPrefs.SetFloat("Guns", 2);
                }
                else if (Bullet)
                {
                    PlayerPrefs.SetFloat("Bullet", 2);
                }
                PlayerPrefs.SetFloat("Coins", coins - Price2);
                Tier2Obj.SetActive(false);
                Tier2 = false;
                Tier3 = true;
                Price = Price3;
                Text.text = "BUY:$" + Price.ToString();
            }
        }
        else if (Tier3)
        {
            if (coins >= Price3)
            {
                if (Gun)
                {
                    PlayerPrefs.SetFloat("Guns", 3);
                }
                else if (Bullet)
                {
                    PlayerPrefs.SetFloat("Bullet", 3);
                }
                PlayerPrefs.SetFloat("Coins", coins - Price3);
                Tier3Obj.SetActive(false);
                Tier3 = false;
                Text.text = "BOUGHT";

            }
        }
    }
}
