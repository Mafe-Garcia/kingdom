using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Botones : MonoBehaviour
{
    public void OnJugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1");
    }

    public void OnCreditos()
    {
        MMSceneLoadingManager.LoadScene("Créditos");
    }

    public void IrAInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void OnDevolver()
    {
        MMSceneLoadingManager.LoadScene("Home");
    }

}
