using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public void StartLoading() {
        SceneManager.LoadSceneAsync(1);
        SceneManager.UnloadSceneAsync(0);
    }

    public void StartGame() {
        SceneManager.LoadSceneAsync(2);
        SceneManager.UnloadSceneAsync(1);
    }

    public void MainMenu() {
        SceneManager.LoadSceneAsync(0);
        SceneManager.UnloadSceneAsync(2);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
