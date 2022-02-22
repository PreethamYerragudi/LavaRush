using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject hittingEnemy;
    private float Countdown = 1;
    public Transform Player;
    public Transform b;
    public float enemySpawnRate = 1f;
    public ParticleSystem SpawnEffect;
    public ParticleSystem yellow;
    // Start is called before the first frame update
    void Start()
    {

    }
    void EnemySpawner()
    {
        Vector3 Position;
        float y = Random.Range(Player.position.y + 6, Player.position.y - 6);
        float x;
        if (y >= 8 || y <= -3.7)
        {
            x = Random.Range(Player.position.x + 10, Player.position.x - 10);
        }
        else
        {
            if (Random.Range(0, 2) == 1)
            {
                x = Player.position.x + 10;
            }
            else
            {
                x = Player.position.x - 10;
            }

        }
        Position = new Vector3(x, y, Player.position.z);
        if (Random.Range(0, 3) == 1)
        {
            Instantiate(yellow, Position, b.rotation);
            Instantiate(enemy, Position, b.rotation);
        }
        else
        {
            Instantiate(SpawnEffect, Position, b.rotation);
            Instantiate(hittingEnemy, Position, b.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {

        Countdown += Time.deltaTime;
        if (Countdown >= enemySpawnRate)
        {
            EnemySpawner();
            Countdown = 0;
        }
        enemySpawnRate -= .000001f;
    }
}
