using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerButtons : MonoBehaviour
{
     int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
  

public void nextScene()
{
 SceneManager.LoadScene(currentSceneIndex+1);
}
public void close()
{
    SceneManager.LoadScene(currentSceneIndex-1);
}
}