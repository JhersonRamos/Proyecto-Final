using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJuegito : MonoBehaviour
{
    public float Fiinalcro;
    public GameObject finalobj1, finalobj2;
  
    void Update()
    {
        Finalpart1();
        Finalpart2();
        Fiinalcro += 1 * Time.deltaTime;
        
    }
    void Finalpart1()
    {
        if(Fiinalcro >= 5f && finalobj1 != null)
        {
            finalobj1.SetActive(true);
        }

    }
    void Finalpart2()
    {
        if(Fiinalcro >= 15f && finalobj2 != null)
        {
            finalobj2.SetActive(true);
        }

    }


}
