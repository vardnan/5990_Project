using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Type in the name of the Scene you would like to load in the Inspector
    public string sceneName;

    // Assign your GameObject you want to move Scene in the Inspector
    private GameObject userModel;

    public void OnClick()
    {
        userModel = GameObject.Find("1");
        StartCoroutine(LoadYourAsyncScene());

    }

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(userModel, SceneManager.GetSceneByName(sceneName));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }
}