using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class MenuP : MonoBehaviour
{
    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject MenuPausa;

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
        MMSceneLoadingManager.LoadScene("Nivel 1");
    }

    public void Cerrar()
    {
        MMSceneLoadingManager.LoadScene("Home");
    }
}
