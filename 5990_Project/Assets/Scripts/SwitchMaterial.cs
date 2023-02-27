using UnityEngine;

/// <summary>
/// This script makes it easier to toggle between a new material, and the objects original material.
/// </summary>
public class SwitchMaterial : MonoBehaviour
{
    [Tooltip("The material that's switched to.")]
    public Material otherMaterial = null;
    private bool usingOther = false;
    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;

    public void SetOtherMaterial()
    {
        meshRenderer = GameObject.Find("1").transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }
}
