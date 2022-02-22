using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("yes", 0);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Difficulty", 0) == 0)
        {
            speed = 2.5f;
        }
        else if (PlayerPrefs.GetFloat("Difficulty", 0) == 1)
        {
            speed = 4f;
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }


}
