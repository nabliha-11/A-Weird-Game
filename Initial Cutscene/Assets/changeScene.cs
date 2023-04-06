using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    int currentSceneIndex;
    void Awake(){
     currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
public void nextScene()
{
 SceneManager.LoadScene(11);
}
public void close()
{
    SceneManager.LoadScene(8);
}
public void left()
{
    SceneManager.LoadScene(8);
}
public void right()
{
    SceneManager.LoadScene(9);
}
}