using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tdas
{
    Metodo1,Metodo2,List
}
public class DesafioTDA : MonoBehaviour
{
    
    [Header("Metodos")]
    public Tdas Metodos;
   

    void Start()
    {
         switch (Metodos)
      {
        case Tdas.Metodo1:
        Desafio10();
        break;
        
        case Tdas.Metodo2:
        Desafio2();
        break;
        
        case Tdas.List:
        List();
        break;
      }
    }

    
    void Update()
    {
     
    }

    private void List()
    {
        List <string> lista = new List<string>();
        lista.Add("Pepito");
        lista.Add("Manuel");
        lista.Add("Pique");
        lista.Add("Pepe");
        lista.Add("Manuelito");


        for(int i = 0; i < lista.Count; i++)
        {
            if(lista [i].Length <= 5 )
            Debug.LogErrorFormat("el nombre "+  lista[i] + " contiene 5 letras o menos");
        }
    }

    private void Desafio10()
    {
        for(int i =0; i < 40 ; i++)
        {
        Debug.Log("Numeros " + i);
        }
    }

    private void Desafio2()
    {
        for(int i = 50 ; i > 0 ; i--)
        {
        Debug.Log("Numeros " + i);
        }
    }

}
