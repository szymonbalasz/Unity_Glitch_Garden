using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float LoadSceneDelay = 4f;
    
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Splash Screen")) { StartCoroutine(LoadStartScreen()); }
    }

    private IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(LoadSceneDelay);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLoseScreen()
    {
        SceneManager.LoadScene("Lose Screen");
    }
}
