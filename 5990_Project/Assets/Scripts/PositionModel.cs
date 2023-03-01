using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PositionModel : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Start()
    {
        GameObject.Find("1").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(0.425f, 0, 0);
        //GameObject.Find("1").transform.GetChild(0).gameObject.transform.position = new Vector3(0.187f, -6.774f, 6.829);
        GameObject.Find("XR Rig").transform.position = new Vector3(0.41f, 0, 1.25f);
        GameObject.Find("XR Rig").transform.rotation = Quaternion.Euler(0, 180, 0);
        GameObject.Find("--INTERFACE--").transform.position = new Vector3(0.36f, -3.37f, -16.98f);
        GameObject.Find("--INTERFACE--").transform.rotation = Quaternion.Euler(0, 90, 0);
        GameObject.Find("Plane").GetComponent<MakePlaneTransparent>().MakeTransparent();

        //test = GameObject.FindGameObjectWithTag("KitchenEvent");
        //UnityEngine.EventSystems.EventSystem.current.enabled = false;
        //GameObject.Find("--INTERFACE--").transform.GetChild(0).gameObject.SetActive(true);
    }

    //private void Update()
    //{
    //    if (UnityEngine.EventSystems.EventSystem.current == null)
    //    {
    //        Debug.Log("Event System is null");
    //        //UnityEngine.EventSystems.EventSystem.current = test.GetComponent<UnityEngine.EventSystems.EventSystem>();
            
    //    }
    //}
}
