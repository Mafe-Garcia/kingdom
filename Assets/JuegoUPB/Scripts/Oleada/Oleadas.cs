using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Oleadas : MonoBehaviour
{
    [SerializeField]
    private List<Ola> olas;
    private int ola_actual;
    [SerializeField]
    private GameObject contenedor_grupos;
    private static Oleadas instance;

    public static Oleadas Instance { get => instance; private set => instance = value; }

    public GameObject ContenedorGrupos { get => contenedor_grupos; set => contenedor_grupos = value; }

    public int OlaActual { get => ola_actual; set => ola_actual = value; }


    public int CantidadOlas()
    {
        return olas.Count;
    }

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void Start(){
        DespacharOla();
    }

    public void DespacharOla(){
        Ola ola;
        if(OlaActual < olas.Count)
        {
            ola = olas[OlaActual];
            ola.EmpezarOla();
            ola.OleadasNivel = this;
            OlaActual++; //Acá se acualiza el contador de olas
           // Debug.Log("Ola "+Ola_actual+"/"+olas.Count);
            MMGameEvent.Trigger("NuevaOla");
        }
        else{
            //Se termina la partida indicar que gano y mostrar ventana fin de nivel
            MMGameEvent.Trigger("UltimaOla");
        }

    }

}
