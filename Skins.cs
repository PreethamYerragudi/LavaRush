using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    private float Number;
    public SpriteRenderer Player;
    public SpriteRenderer Eye;
    public SpriteRenderer Wood;
    public SpriteRenderer Glass;
    public SpriteRenderer Face;
    public SpriteRenderer Ball;
    public SpriteRenderer Leather;
    // Update is called once per frame
    void Update()
    {
        Number = PlayerPrefs.GetFloat("Skin",0);
        if (Number == 1)
        {
            Player.enabled = false;
            Eye.enabled = true;
            Wood.enabled = false;
            Glass.enabled = false;
            Face.enabled = false;
            Ball.enabled = false;
            Leather.enabled = false;
        }else if (Number == 2)
        {
            Player.enabled = false;
            Wood.enabled = true;
            Eye.enabled = false;
            Glass.enabled = false;
            Face.enabled = false;
            Ball.enabled = false;
            Leather.enabled = false;
        }
        else if (Number == 3)
        {
            Player.enabled = false;
            Face.enabled = true;
            Wood.enabled = false;
            Glass.enabled = false;
            Eye.enabled = false;
            Ball.enabled = false;
            Leather.enabled = false;
        }
        else if (Number == 4)
        {
            Player.enabled = false;
            Eye.enabled = false;
            Wood.enabled = false;
            Glass.enabled = true;
            Face.enabled = false;
            Ball.enabled = false;
            Leather.enabled = false;
        }
        else if (Number == 5)
        {
            Player.enabled = false;
            Ball.enabled = true;
            Wood.enabled = false;
            Glass.enabled = false;
            Face.enabled = false;
            Eye.enabled = false;
            Leather.enabled = false;
        }
        else if (Number == 6)
        {
            Player.enabled = false;
            Leather.enabled = true;
            Wood.enabled = false;
            Glass.enabled = false;
            Face.enabled = false;
            Ball.enabled = false;
            Eye.enabled = false;
        }
    }
}
