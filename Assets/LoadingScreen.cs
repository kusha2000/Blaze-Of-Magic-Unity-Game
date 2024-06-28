using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public void Loading(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));


    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
