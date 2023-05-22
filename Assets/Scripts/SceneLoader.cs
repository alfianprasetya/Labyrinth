using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void SceneLoad(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
  }

  public void Restart()
    {
      var currentScene = SceneManager.GetActiveScene();
      int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);

      SceneManager.LoadScene("Level " + currentLevel);
    }

  public void Quit()
  {
    Application.Quit();
  }
}
