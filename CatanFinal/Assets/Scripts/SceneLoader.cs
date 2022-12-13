using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Load main menu scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    //Exit Button

}
