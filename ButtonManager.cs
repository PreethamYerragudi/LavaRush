using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    public RectTransform UI;
    private Vector3 Position;
    private int x;
    public RectTransform Canvas;
    public CanvasScaler Canva;
    // Start is called before the first frame update
    void Start()
    {
        if (Canva.scaleFactor == 0.7f)
        {
            x = -1059;
        }
        else
        {
            x = -1309 - 176;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Position = new Vector3(UI.position.x+x, transform.position.y, 0f);
        transform.position = Position;
        
    }
}
