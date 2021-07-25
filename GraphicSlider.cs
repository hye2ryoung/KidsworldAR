using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSlider : MonoBehaviour
{
    public Slider GraphicControl;
    private int GraphicValue;

    void Start()
    {
        GraphicValue = PlayerPrefs.GetInt("Graphic");

        if (GraphicValue == 0) GraphicControl.value = 0;
        else if (GraphicValue == 1) GraphicControl.value = 1;
        else if (GraphicValue == 2) GraphicControl.value = 2;
    }

    public void GraphicSetting()
    {
        if (GraphicControl.value == 0)
        {
            GraphicControl.handleRect.anchorMin = new Vector2(0, 0);
            GraphicControl.handleRect.anchorMax = new Vector2(0, 1);
            PlayerPrefs.SetInt("Graphic", 0);
        }
        else if (GraphicControl.value == 1)
        {
            GraphicControl.handleRect.anchorMin = new Vector2(0.5f, 0);
            GraphicControl.handleRect.anchorMax = new Vector2(0.5f, 1);
            PlayerPrefs.SetInt("Graphic", 1);
        }
        else if (GraphicControl.value == 2)
        {
            GraphicControl.handleRect.anchorMin = new Vector2(1, 0);
            GraphicControl.handleRect.anchorMax = new Vector2(1, 1);
            PlayerPrefs.SetInt("Graphic", 2);
        }
    }
    
}
