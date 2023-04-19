using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efectos : MonoBehaviour
{
    
    public void ActivarObjeto(GameObject obj)
    {
        obj.SetActive(true);
        Debug.Log("Activando Objeto: " + obj.name);
    }
    public void DecirHola()
    {
        Debug.LogErrorFormat("Hola");
    }
    public void CambiarColorAlVerde(GameObject obj)
    {
        obj.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        Debug.Log("Cambiando Color a Verde al Objeto: " + obj.name);
    }
    public void DesactivarrObjeto(GameObject obj)
    {
        obj.SetActive(false);
        Debug.Log("Desactivando Objeto: " + obj.name);
    }
}
