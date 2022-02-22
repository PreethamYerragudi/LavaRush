using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Player;
    private float fireCountdown=0;
    public GameObject Bullet;
    public GameObject ToxicBullet;
    public GameObject NuclearBullet;
    public GameObject OtherBullet;
    public float fireRate = 3f;
    public Joystick joystick;
    public bool Exile = true;
    private float x;
    private float y;
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (joystick.Horizontal > 0 || joystick.Horizontal < 0 || joystick.Vertical > 0 || joystick.Vertical < 0)
            {
            if (PlayerPrefs.GetInt("Tut",0)==1)
            {
                PlayerPrefs.SetInt("Tut", 2);
            }
            x = joystick.Horizontal;
            y = joystick.Vertical;
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
                Player.rotation = Quaternion.Euler(0f, 0f, angle);
                fireCountdown += Time.deltaTime;
                if (fireCountdown >= 1)
                {

                    if (PlayerPrefs.GetFloat("Bullet", 0) == 0)
                    {
                    bullet = Instantiate(Bullet, transform.position, transform.rotation);
                    }
                else if(PlayerPrefs.GetFloat("Bullet", 0) == 1)
                {
                    bullet = Instantiate(ToxicBullet, transform.position, transform.rotation);
                }
                else if(PlayerPrefs.GetFloat("Bullet", 0) == 2)
                {
                   bullet = Instantiate(NuclearBullet, transform.position, transform.rotation);
                }
                else if(PlayerPrefs.GetFloat("Bullet", 0) == 3)
                {
                   bullet = Instantiate(OtherBullet, transform.position, transform.rotation);
                }
                   
                    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                    rb.AddForce(transform.right * 20f, ForceMode2D.Impulse);
                    fireCountdown = 0f;
                }

            }

        
    }
    

}
