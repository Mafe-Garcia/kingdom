using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oleadas : MonoBehaviour
{
    [SerializeField]
    private List<Ola> olas;
    private int ola_actual;
    [SerializeField]
    private GameObject contenedor_grupos;
    public static Oleadas Instance { get; private set; }
    public GameObject ContenedorGrupos { get => contenedor_grupos; set => contenedor_grupos = value; }
    public global::System.Int32 Ola_actual { get => ola_actual; set => ola_actual = value; }

    public int CantidadOlas()
    {

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
        if(Ola_actual < olas.Count)
        {
            ola = olas[Ola_actual];
            ola.EmpezarOla();
            ola.OleadasNivel = this;
            Ola_actual++; //Acá se acualiza el contador de olas
            Debug.Log("Ola "+Ola_actual+"/"+olas.Count);
            MMGameEvent.Trigger("NuevaOla");
        }
        else{
            //Se termina la partida indicar que gano y mostrar ventana fin de nivel
            Debug.Log("Fin de oleadas");
        }

    }

    /*public Enemigo BuscarEnemigoDisponible(TipoEnemigo tipo)
    {
        return null;
    }*/
}
