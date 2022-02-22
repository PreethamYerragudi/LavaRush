using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class Graph : MonoBehaviour
{
    private PostProcessLayer Nice;
    public GameObject Ground;
    // Start is called before the first frame update
    void Start()
    {
        Nice = gameObject.GetComponent<PostProcessLayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Graphics", 0) == 0)
        {
            Nice.enabled = true;
            Ground.SetActive(true);
        }
        else
        {
            Nice.enabled = false;
            Ground.SetActive(false);
        }
    }
}
