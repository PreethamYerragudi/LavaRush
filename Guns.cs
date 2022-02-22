using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    private float Number;
    public GameObject Tier2Gun;
    public GameObject Tier3Gun;
    public GameObject Tier3Gun2;

    // Update is called once per frame
    void Update()
    {
        Number = PlayerPrefs.GetFloat("Guns", 0);
        if (Number == 1)
        {
            Tier2Gun.SetActive(true);
        }
        else if (Number == 2)
        {
            Tier3Gun.SetActive(true);
            Tier3Gun2.SetActive(true);
            Tier2Gun.SetActive(false);
        }
        else if (Number == 3)
        {
            Tier3Gun.SetActive(true);
            Tier3Gun2.SetActive(true);
            Tier2Gun.SetActive(true);
        }
    }
}
