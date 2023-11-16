using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField] private GameObject Gano;
    private string nextScene;
    private int vidas;

    public void OnMMEvent(MMGameEvent eventType)
    {
        if (eventType.EventName == "UltimaOla")
        {
            Gano.SetActive(true);
        }

        
        

    }


    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }



    public void OnSiguiente()
    {

        Scene scene = SceneManager.GetActiveScene();

        vidas = GameManager.Instance.CurrentLives;

        if (scene.name == "Nivel 1")
        {

            nextScene = "Nivel 2";

            vidas = GameManager.Instance.MaximumLives;
        }
        else
        {
            nextScene = "Nivel 3";

            vidas = GameManager.Instance.MaximumLives; 
        }
        
        
        MMSceneLoadingManager.LoadScene(nextScene);

    }


    public void OnFinal()
    {

        Scene scene = SceneManager.GetActiveScene();

        vidas = GameManager.Instance.CurrentLives;

        if (scene.name == "Nivel 1")
        {

            nextScene = "Nivel 2";

            vidas = GameManager.Instance.MaximumLives;
        }
        else if (scene.name == "Nivel 2")
        {
            nextScene = "Nivel 3";

            vidas = GameManager.Instance.MaximumLives;
        }
        else
        {
            nextScene = "Final";

        }


        MMSceneLoadingManager.LoadScene(nextScene);

    }

}
