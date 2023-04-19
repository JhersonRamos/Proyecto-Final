using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDaño : MonoBehaviour
{
    public float CantidadDeDaño = 7;
    private void OnTriggerStay(Collider other) 
    {
      if(other.CompareTag("Player") && other.GetComponent<_UI_>())
      {
        other.GetComponent<_UI_>().RecibirDaño(CantidadDeDaño);
      }  
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
