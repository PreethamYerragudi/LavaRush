using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    public RectTransform Canvas;
    public RectTransform Controller;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Controller.sizeDelta = new Vector2(Canvas.rect.width, Canvas.rect.height);
    }
}
