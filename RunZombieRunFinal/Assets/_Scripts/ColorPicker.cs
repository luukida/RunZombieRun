using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Slider sliderRed, sliderGreen, sliderBlue, sliderAlpha;
    public Image colorImage;

    void Start()
    {
        sliderRed.value = colorImage.color.r;
        sliderGreen.value = colorImage.color.g;
        sliderBlue.value = colorImage.color.b;
        sliderAlpha.value = colorImage.color.a;
    }

    public void UpdateRed(float value)
    {
        colorImage.color = new Color(value, colorImage.color.g, colorImage.color.b, colorImage.color.a);
    }

    public void UpdateGreen(float value)
    {
        colorImage.color = new Color(colorImage.color.r, value, colorImage.color.b, colorImage.color.a);
    }

    public void UpdateBlue(float value)
    {
        colorImage.color = new Color(colorImage.color.r, colorImage.color.g, value, colorImage.color.a);
    }

    public void UpdateAlpha(float value)
    {
        colorImage.color = new Color(colorImage.color.r, colorImage.color.g, colorImage.color.b, value);
    }
}
