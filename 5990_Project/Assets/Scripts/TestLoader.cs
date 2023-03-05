using TriLibCore;
using TriLibCore.General;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TestLoader : MonoBehaviour
{
    // Lets the user load a new model by clicking a GUI button.....
    public string ModelURL = "https://drive.google.com/uc?export=download&id=1xbglMHX6La4i_lZ9EojLminQb0svTgkv";

    /// <summary>
    /// Creates the AssetLoaderOptions instance, configures the Web Request, and downloads the Model.
    /// </summary>
    /// <remarks>
    /// You can create the AssetLoaderOptions by right clicking on the Assets Explorer and selecting "TriLib->Create->AssetLoaderOptions->Pre-Built AssetLoaderOptions".
    /// </remarks>
    ///

    public void OnClick()
    {
        var assetLoaderOptions = AssetLoader.CreateDefaultLoaderOptions();
        var webRequest = AssetDownloader.CreateWebRequest(ModelURL);
        AssetDownloader.LoadModelFromUri(webRequest, OnLoad, OnMaterialsLoad, OnProgress, OnError, null, assetLoaderOptions, null, "fbx");
    }

    // This event is called when the model loading progress changes.
    // You can use this event to update a loading progress-bar, for instance.
    // The "progress" value comes as a normalized float (goes from 0 to 1).
    // Platforms like UWP and WebGL don't call this method at this moment, since they don't use threads.
    private void OnProgress(AssetLoaderContext assetLoaderContext, float progress)
    {

    }

    // This event is called when there is any critical error loading your model.
    // You can use this to show a message to the user.
    private void OnError(IContextualizedError contextualizedError)
    {

    }

    // This event is called when all model GameObjects and Meshes have been loaded.
    // There may still Materials and Textures processing at this stage.
    private void OnLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // If you want to make sure the GameObject will be visible only when all Materials and Textures have been loaded, you can disable it at this step.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(false);
    }

    // This event is called after OnLoad when all Materials and Textures have been loaded.
    // This event is also called after a critical loading error, so you can clean up any resource you want to.
    private void OnMaterialsLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // You can make the GameObject visible again at this step if you prefer to.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(true);

        MeshRenderer[] mrs = myLoadedGameObject.GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer m in mrs)
        {
            GameObject theObject = m.gameObject;
            MeshCollider mC = theObject.AddComponent<MeshCollider>();
            mC.convex = true;
            Rigidbody rB = theObject.AddComponent<Rigidbody>();
            rB.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            rB.useGravity = false;
            rB.isKinematic = true;
            theObject.AddComponent(typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable));
            theObject.transform.position = new Vector3(0, 0.5f, 0);
            //get all the meshrenderer componenents




            //do to dimensions...
            //takes the boundary of the mesh renderer....
            //m.bounds.center;
            //m.bounds.size.x;
            //m.bounds.size.y;
            //m.bounds.size.z;

        }

        

        /*
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.AddComponent<MeshRenderer>();
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.AddComponent<MeshCollider>();
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<MeshCollider>().convex = true;
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
        //myLoadedGameObject.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.AddComponent(typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable));
        myLoadedGameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(0, 0.5f, 0);
        */

        DontDestroyOnLoad(myLoadedGameObject);
    }
}