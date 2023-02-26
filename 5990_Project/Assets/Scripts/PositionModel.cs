using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("1").transform.GetChild(0).gameObject.transform.position = new Vector3(3.95f, 0.15f, 11.14f);
    }
}
