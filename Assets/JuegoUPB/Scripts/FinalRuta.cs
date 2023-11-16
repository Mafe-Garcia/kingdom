using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.Events;

public class FinalRuta : MonoBehaviour
{
   
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {            
            Debug.Log("si se que es");
            GameManager.Instance.LoseLife();
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("no se que es, " + gameObject.name);
        }      
        
        
    }
}
