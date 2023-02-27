using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionModel : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        //GameObject.Find("1").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(0.114f, 7.1f, 0.252f);
        GameObject.Find("1").transform.GetChild(0).gameObject.transform.position = new Vector3(0.293f, 0.5f, -6.7f);
    }
}
