using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEngine;
using MoreMountains.Tools;


public class ContadorVidas : MonoBehaviour
{
    [SerializeField]
    private TMP_Text contador;

 
    // Update is called once per frame
    void Update()
    {

        
        if (GameManager.Instance.CurrentLives > 0)
        {
            contador.SetText(GameManager.Instance.CurrentLives.ToString());
        }
        else
        {            
            MMSceneLoadingManager.LoadScene("GameOver");
        }
       
    }
}
