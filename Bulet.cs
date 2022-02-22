using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    private float countdown=5f;
    public ParticleSystem.MainModule settings;
    public SpriteRenderer enemyColor;
    public ParticleSystem death;
    private CameraShaker Shake;
    private int Amount=1;
    // Start is called before the first frame update
    private void Start()
    {
        Shake = GameObject.FindGameObjectWithTag("Respawn").GetComponent<CameraShaker>();
        if (PlayerPrefs.GetFloat("Bullet", 0) == 0)
        {
            Amount = 1;
        }
        else if (PlayerPrefs.GetFloat("Bullet", 0) == 1)
        {
            Amount = 2;
        }
        else if (PlayerPrefs.GetFloat("Bullet", 0) == 2)
        {
            Amount = 3;
        }
        else if (PlayerPrefs.GetFloat("Bullet", 0) == 3)
        {
            Amount = 4;
        }
    }
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OwO")
        {
            Shake.Shake(.15f,Random.Range(.2f,.5f));
            Instantiate(death,collision.transform.position,collision.transform.rotation);
            Destroy(collision.gameObject);
            Amount -= 1;
            if (Amount <= 0)
            {
                Destroy(gameObject);
            }
            Debug.Log("Please, Why u no work?");
       }
    }

}
