using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ARGplaybutton : MonoBehaviour
{
    [SerializeField] GameObject loadingScreen;//Prefab;
    
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        loadingScreen.SetActive(true);
        //var prefab = Instantiate(loadingScreenPrefab);
        //DontDestroyOnLoad(prefab);
        var sceneLoading = SceneManager.LoadSceneAsync(sceneIndex);
        sceneLoading.allowSceneActivation = false;
        
        while (sceneLoading.isDone == false)
        {
            if (sceneLoading.progress >= 0.9f)
            {
                sceneLoading.allowSceneActivation = true;
                loadingScreen.SetActive(false);
            }
            yield return null;
        }
    }

    public void ToMenu(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ToControls(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ToCredits(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ToQuit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
