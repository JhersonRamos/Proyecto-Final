using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo3 : MonoBehaviour
{
    public GameObject Trigerd;

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
        Trigerd.SetActive(true);
        }
    }
}
