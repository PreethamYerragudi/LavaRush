using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    public AudioSource Audio;
    public SpriteRenderer Sp;
    public string gameId = "4022622";
    private string r = "rewardedVideo";
    private string v = "video";
    public GameObject Player;
    public GameObject GameOver;
    private GameObject[] Enemies;
    public GameObject controller;
    private void Update()
    {

    }
    // Start is called before the first frame update
    private void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
    }
    public void ShowAd()
    {
        if (Advertisement.IsReady()) {
            Advertisement.Show(r);
        }
        else
        {
            Debug.Log("error");
        }
            
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Enemies = GameObject.FindGameObjectsWithTag("OwO");
            if (Enemies.Length > 0)
            {
                for (var i = 0; i < Enemies.Length; i++)
                {
                    Destroy(Enemies[i]);
                }
            }
            PlayerPrefs.SetInt("$", PlayerPrefs.GetInt("$", 0) + 1);
            PlayerPrefs.SetInt("yes", 1);
            GameOver.SetActive(false);
            controller.SetActive(true);
            Player.SetActive(true);
        }
        else if (showResult == ShowResult.Failed)
        {
            //Oh no!
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
       
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }
}

