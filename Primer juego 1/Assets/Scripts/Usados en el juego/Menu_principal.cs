using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_principal : MonoBehaviour
{
    
    public void SalirDelJuego()
    {
        Application.Quit();

    }
    public void Jugar()
    {
       SceneManager.LoadScene("House on night");

    }

}
