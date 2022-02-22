using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private float x;
    public GameObject Player;
    private Vector3 GroundPos;
    private float vel;
    private bool gameOver=false;
    public ParticleSystem Effect;
    public PlayerMovement Enemy;
    // Start is called before the first frame update
    void Start()
    {
        x = -9f;
        vel = .01f;
    }

    // Update is called once per frame
    void Update()
    {

        //Moving the Ground
        if (vel<=.95f)
        {
            vel += .00000005f;
        }
        x += vel;
        //Moving Ground to match with player
        if (gameOver == false)
        {
            GroundPos = new Vector3(x, Player.transform.position.y, 0);
            transform.position = GroundPos;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameOver = true;
            collision.gameObject.SetActive(false);
            Enemy.GameOver = true;
        }
    }
}
