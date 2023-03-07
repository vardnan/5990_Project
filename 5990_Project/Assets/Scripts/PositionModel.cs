using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.XR.Interaction.Toolkit;

public class PositionModel : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 modelPosition;

    XRGrabInteractable grabInteractor;

    private void Start()
    {
        //GameObject.Find("1").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(0.425f, 1, 0);
        GameObject.Find("1").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.position = modelPosition;
        StartCoroutine(UpdateXRManager());
    }

    IEnumerator UpdateXRManager()
    {
        MeshRenderer[] mrs = GameObject.Find("1").GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer m in mrs)
        {
            GameObject theObject = m.gameObject;
            grabInteractor = (XRGrabInteractable)theObject.GetComponent(typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable));
            Destroy(grabInteractor);

            while (grabInteractor != null)
            {
                yield return null;
            }

            theObject.AddComponent(typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable));
        }
    }

 //void updateXRInteractionManager()

 //   {
 //       MeshRenderer[] mrs = GameObject.Find("1").GetComponentsInChildren<MeshRenderer>();

 //       foreach (MeshRenderer m in mrs)
 //       {
 //           GameObject theObject = m.gameObject;

 //            (grabInteractor == null)
 //           {
 //               theObject.AddComponent(typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable));
 //           }
 //       }

        //private void Update()
        //{
        //    if (UnityEngine.EventSystems.EventSystem.current == null)
        //    {
        //        Debug.Log("Event System is null");
        //        //UnityEngine.EventSystems.EventSystem.current = test.GetComponent<UnityEngine.EventSystems.EventSystem>();

        //    }
        //}
}
