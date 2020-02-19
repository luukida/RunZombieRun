using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Example : MonoBehaviour
{
    public Image meatImage;
    public float meatConsumption = 0.1f;
    public float meatRestoration = 1f;

    public TMP_InputField consumptionInputField, restorationInputField;

    private bool victory = false;

    public void Eat ()
    {
        if(victory)
        {
            victory = false;
            meatImage.fillAmount = 1f;
            meatRestoration += 0.1f;
        }

        meatImage.fillAmount -= meatConsumption;

        if (meatImage.fillAmount <= 0)
        {
            victory = true;
            meatImage.fillAmount = 0;
            Debug.Log("Victory!");
        }

        Debug.Log("Current meat left = " + meatImage.fillAmount);
    }

    private void Update()
    {
        if (victory) return;

        meatImage.fillAmount += Time.deltaTime * meatRestoration;
    }

    public void GetRestorationValue(string value)
    {
        Debug.Log("New restoration value = " + value);
        float newValue = float.Parse(value);
    }

    public void GetConsupmtionValue(string value)
    {
        Debug.Log("New consumption value = " + value);
        float newValue = float.Parse(value);
    }
}
