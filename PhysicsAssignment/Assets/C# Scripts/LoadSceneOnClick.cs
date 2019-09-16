using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{


    public void LoadSceneByIndex(int sceneIndex)    //as the name suggests, loads a scene on click
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
