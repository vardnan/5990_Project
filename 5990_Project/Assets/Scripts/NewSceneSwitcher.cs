using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneSwitcher : MonoBehaviour
{
    private GameObject UIRootObject;
    private AsyncOperation sceneAsync;

    public void OnClick()
    {
        
        UIRootObject = GameObject.Find("1");
        StartCoroutine(loadScene(1));
    }


    IEnumerator loadScene(int index)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation scene = SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);

        //scene.allowSceneActivation = false;
        //sceneAsync = scene;

        //Wait until we are done loading the scene
        //while (scene.progress < 0.9f)
        //{
        //    Debug.Log("Loading scene " + " [][] Progress: " + scene.progress);
        //    yield return null;
        //}


        while (!scene.isDone)
        {
            yield return null;
        }

        OnFinishedLoadingAllScene();
        SceneManager.UnloadSceneAsync(currentScene);
    }

    void enableScene(int index)
    {
        //Activate the Scene
        //sceneAsync.allowSceneActivation = true;
  

        Scene sceneToLoad = SceneManager.GetSceneByBuildIndex(index);
        if (sceneToLoad.IsValid())
        {
            Debug.Log("Scene is Valid");
            SceneManager.MoveGameObjectToScene(UIRootObject, sceneToLoad);
            SceneManager.SetActiveScene(sceneToLoad);
        }
    }

    void OnFinishedLoadingAllScene()
    {

        Debug.Log("Done Loading Scene");
        enableScene(1);
        Debug.Log("Scene Activated!");
    }
}
