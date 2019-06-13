using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float LoadSceneDelay = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Splash Screen")) { StartCoroutine(LoadStartScreen()); }
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void QuitGame()
    {
        Application.Quit();
    }
}
