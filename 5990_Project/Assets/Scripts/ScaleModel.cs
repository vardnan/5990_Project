using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleModel : MonoBehaviour
{

    public void scaleModel(Slider mySlider)
    {
        GameObject.Find("1").transform.GetChild(0).gameObject.transform.localScale = new Vector3(1,1,1) * mySlider.value;
    }
}
