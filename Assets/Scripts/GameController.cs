using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

   // Defino un GameControler estático
    public static GameController control;

    // Monobehavior Awake, no destuiré acá la scene pq quiero que siempre exista
    private void Awake()
    {
        control = this;
    }

    // Use this for initialization
    void Start () {

        //cuando el juego empieza cargo la escena FruitsLesson
        StartCoroutine(LoadScene("FruitsLesson"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Este método lo creo para cargar la escena con el nombre dado por parámetro
    public IEnumerator LoadScene(string sceneName)
    {
        //Espero hasta que finalice el frame actual
        yield return new WaitForEndOfFrame();

        //Quito la(s) escena(s) previa(s)
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        StartCoroutine(UnloadScenes(sceneName));
    }

    // Este método lo creo para quitar las escenas, excepto "Exception" y "Menu"
    private IEnumerator UnloadScenes(string exception)
    {
        yield return new WaitForEndOfFrame();

        // SceneManager.sceneCount me da el número total de escenas cargadas en runtime
        // Por lo tanto, en este for, por cada una de las escenas cargadas
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            //si no es la nueva escena cargarda o el Menu, la quito
            if(SceneManager.GetSceneAt(i).name != exception && SceneManager.GetSceneAt(i).name!= "Menu")
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i).name);
            }

        }
    }
}
