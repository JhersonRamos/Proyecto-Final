using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _UI_ : MonoBehaviour
{
    public float vidajugador = 100f;
    float saludmaxima = 100f;
    public Image BarraDeSalud;
    public GameObject Muerto;
    
    public CanvasGroup OjosRojos;
    bool Pausa;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(OjosRojos.alpha > 0)
        {OjosRojos.alpha -= Time.deltaTime;}

        Vida_y_Salud();
        
    }
    public void RecibirDaño(float daño)
    {
        vidajugador -= daño * Time.deltaTime;
        OjosRojos.alpha = 1;

        if(vidajugador <= 0)
        {
            Instantiate(Muerto);
            Destroy(gameObject);
        }
    }
    void Vida_y_Salud()
    {
        BarraDeSalud.fillAmount = vidajugador / saludmaxima;

    }
    #region Pausa
        
       
    void TogglePause()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
         if(Pausa == true)
        {
            ResumirJuego();
        }else{PausarJuego();}

      }

    }

    void ResumirJuego()
    {
        Time.timeScale = 1;
        Pausa = false;
    }

    void PausarJuego()
    {
        Time.timeScale = 0f;
        Pausa = true;
    }
    #endregion
}
