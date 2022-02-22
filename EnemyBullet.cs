using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float countdown=5f;
    private PlayerMovement Enemy;
    // Start is called before the first frame update
    private void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Yayeet").GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
            Enemy.GameOver = true;
            Debug.Log(Enemy.GameOver);
        }
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Destroy(gameObject);
        }
    }
}
