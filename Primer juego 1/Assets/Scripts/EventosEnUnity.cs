using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EventosEnUnity : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    private void OnTriggerEnter(Collider col) 
    {
        if(col.CompareTag("Player"))
        {
            myTrigger.Invoke();
            gameObject.SetActive(true);
        }
    }
    

    
    void Update()
    {
        
    }
}
