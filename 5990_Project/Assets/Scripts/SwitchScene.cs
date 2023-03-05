using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Name of the Scene I would like to load, which is assigned in the Inspector
    public string sceneName;

    // Assigning the GameObject I want to move to the next scene
    private GameObject userModel;

    //public void OnClick()
    //{
    //    // Finding the user's uploaded model, which has a parent GameObject named "1"
    //    userModel = GameObject.Find("1");
    //    StartCoroutine(LoadYourAsyncScene());

    //}

    //IEnumerator LoadYourAsyncScene()
    //{

    //    // Setting the current Scene to be able to unload it later
    //    Scene currentScene = SceneManager.GetActiveScene();

    //    // The Application loads the Scene in the background at the same time as the current Scene.
    //    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

    //    // Waiting until the last operation fully loads to return anything
    //    while (!asyncLoad.isDone)
    //    {
    //        yield return null;
    //    }

    //    // Moving the GameObject to the newly loaded Scene
    //    SceneManager.MoveGameObjectToScene(userModel, SceneManager.GetSceneByName(sceneName));

    //    // Unloading the previous Scene
    //    SceneManager.UnloadScene(currentScene);

    //}

    public void ChangeMyScene()
    {
        //this won't be able to have a loading screen or anything... itll just go black between scenes  
        SceneManager.LoadScene(sceneName);
    }
}