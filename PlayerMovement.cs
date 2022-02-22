using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    private float horizontalMove;
    private float verticalMove;
    private Vector3 Move;
    public TextMeshProUGUI pistance;
    public float distance=0;
    private string DistString;
    public TextMeshProUGUI DistanceText;
    public TextMeshProUGUI Coin;
    public GameObject Panel;
    public GameObject Ui;
    public Buying Buy;
    private float CoinTotal;
    public float Coins;
    private float x = .15f;
    public ParticleSystem Enemy;
    private PlayerMovement DistScript;
    private float Distance;
    private float DistanceCount;
    public int CoinCount;
    public bool GameOver = false;
    private bool CoinsCount = false;
    public GameObject GameOv;
    // Start is called before the first frame update
    void Start()
    {

            PlayerPrefs.SetInt("yes", 0);
            DistScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            CoinTotal = PlayerPrefs.GetFloat("Coins");
    
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontalMove > 0 || horizontalMove < 0 || verticalMove > 0 || verticalMove < 0)
        {
            if (PlayerPrefs.GetInt("Tut",0)==0)
            {
                PlayerPrefs.SetInt("Tut", 1);
            }
        }
        horizontalMove = joystick.Horizontal*.12f;
        verticalMove = joystick.Vertical*.12f;
        distance += horizontalMove*5f;
        Move = new Vector3(horizontalMove, verticalMove, 0);
        transform.position += Move;
        DistString = "Distance: "+distance.ToString("F2");
        pistance.text = DistString;
            if (GameOver)
        {
            GameOv.SetActive(true);
            Distance = DistScript.distance;
            Coins = Mathf.Round(Distance / 20);
            DistScript.Ui.SetActive(false);
            DistScript.Panel.SetActive(true);
            x = (Distance/100) * .50f;
            if (DistanceCount<Distance)
            {
                DistanceCount += x;
                DistScript.DistanceText.text = "Distance: " + DistanceCount.ToString("F2");
            }
            else
            {
                GameOv.SetActive(false);
            }
if (DistanceCount >= Distance)
{
    if (CoinCount < Coins)
    {
        CoinCount++;
        DistScript.Coin.text = "Coins: " + CoinCount.ToString();
    }
}
if (CoinCount >= Coins || PlayerPrefs.GetInt("yes") == 1)
{
    for (var i = 0; i < 1; i++)
    {
        CoinCounter();
    }
    PlayerPrefs.SetInt("yes", 0);
    GameOver = false;

}
        }

    }
    private void CoinCounter()
{
    CoinTotal += Coins;
    PlayerPrefs.SetFloat("Coins", CoinTotal);

}
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OwO")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("yes", 0);
            GameOver = true;

        }
    }
}
