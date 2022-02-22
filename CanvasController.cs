using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    public RectTransform Canvas;
    public CanvasScaler Canva;
    // Start is called before the first frame update
    private void Start()
    {
        if (Canvas.rect.width <= 1792)
        {
            Canva.scaleFactor = 0.7f;
        }
        else
        {
            Canva.scaleFactor = 1f;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
