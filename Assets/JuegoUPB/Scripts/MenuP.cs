using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class MenuP : MonoBehaviour
{
    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject MenuPausa;
    private string currentScene;

    void Start()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Nivel 1")
        {

            currentScene = "Nivel 1";
        }
        else if (scene.name == "Nivel 2")
        {
            currentScene = "Nivel 2";
        }
        else if (scene.name == "Nivel 3")
        {
            currentScene = "Nivel 3";
        }
    }

    public void OnPausa()
    {
        Time.timeScale = 0f;
        BotonPausa.SetActive(false);
        MenuPausa.SetActive(true);
        


        

    }

    public void OnReanudar()
    {
        Time.timeScale = 1f;
        BotonPausa.SetActive(true);
        MenuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        MMSceneLoadingManager.LoadScene(currentScene);
    }

    public void Cerrar()
    {
        MMSceneLoadingManager.LoadScene("Home");
    }
}
