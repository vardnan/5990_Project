using UnityEngine;

/// <summary>
/// This script makes it easier to toggle between a new material, and the objects original material.
/// </summary>
public class MakePlaneTransparent : MonoBehaviour
{
    [Tooltip("The material that's switched to.")]
    public Material otherMaterial = null;
    public MeshRenderer planeRenderer = null;
    

    public void MakeTransparent()
    {
        planeRenderer = gameObject.GetComponent<MeshRenderer>();
        planeRenderer.material = otherMaterial;
    }
}
