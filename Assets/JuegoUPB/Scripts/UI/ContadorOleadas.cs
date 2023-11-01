using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorOleadas : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private TMP_Text texto;
    // Start is called before the first frame update
    public void OnMMEvent(MMGameEvent eventType)
    {
        if (eventType.EventName = "Nueva Ola")
        {
            int ola_actual = ContadorOleadas.Instance.OlaActual;
            int cantidad_olas;
            texto.text = "Ola " + ola_actual + "/" + cantidad_olas;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
