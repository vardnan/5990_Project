using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScaleModel : MonoBehaviour
{
    TMP_Text widthValue;
    TMP_Text heightValue;
    TMP_Text depthValue;

    private void Awake()
    {
        widthValue = GameObject.FindGameObjectWithTag("WidthChange").GetComponent<TMP_Text>();
        heightValue = GameObject.FindGameObjectWithTag("HeightChange").GetComponent<TMP_Text>();
        depthValue = GameObject.FindGameObjectWithTag("DepthChange").GetComponent<TMP_Text>();
    }

    private void Start()
    {

        UpdateScale();
    }

    public void scaleModel(Slider mySlider)
    {
        //GameObject.Find("1").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1,1,1) * mySlider.value;

        MeshRenderer[] mrs = GameObject.Find("1").GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer m in mrs)
        {
            GameObject theObject = m.gameObject;
            theObject.transform.localScale = new Vector3(1, 1, 1) * mySlider.value;

        }

        UpdateScale();
    }

    private void UpdateScale()
    {
        MeshRenderer[] mrs = GameObject.Find("1").GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer m in mrs)
        {
            GameObject theObject = m.gameObject;
            widthValue.text = Math.Round((m.bounds.size.x * 100f), 2).ToString() + "cm";
            heightValue.text = Math.Round((m.bounds.size.y * 100f), 2).ToString() + "cm";
            depthValue.text = Math.Round((m.bounds.size.z * 100f), 2).ToString() + "cm";
            Debug.Log("Width:" + m.bounds.size.x);
            Debug.Log("Height:" + m.bounds.size.y);
            Debug.Log("Depth:" + m.bounds.size.z);
        }
    }
}
