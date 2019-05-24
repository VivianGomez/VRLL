using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadOnClick : MonoBehaviour
{
    public GameObject loadingImage;
    //Este método lo creo para cargar la escena con el nombre dado por parámetro
    public void LoadScene(string sceneName)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}