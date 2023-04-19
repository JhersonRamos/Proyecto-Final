using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHerencia1 : MonoBehaviour
{
    void Start()
    {
        //Enemigos comunes
        Enemigos enemigo1 = new Enemigos();
        enemigo1.daño = 25f;
        enemigo1.vida = 150f;
        enemigo1.nombre = "Esqueleto Gerrero";
        Debug.Log("Tipo: " + enemigo1.nombre + " , Daño realizado: " + enemigo1.daño + " , Vida restante: " + enemigo1.vida );
        enemigo1.ataque(); 

        Enemigos enemigo2 = new Enemigos();
        enemigo2.daño = 10f;
        enemigo2.vida = 100f;
        enemigo2.nombre = "Esqueleto Arquero";
        Debug.Log("Tipo: " + enemigo2.nombre + " , Daño a distancia realizado: " + enemigo2.daño + " , Vida restante: " + enemigo2.vida );
        enemigo2.ataque(); 
        Debug.Log("   ");

        //Enemigo Especial
        Enemigos_Especiales enemigoEspecial1 = new Enemigos_Especiales();
        enemigoEspecial1.daño = 40f;
        enemigoEspecial1.vida = 500f;
        enemigoEspecial1.nombre = "Esqueleto Gigante";
        Debug.Log("Tipo: " + enemigoEspecial1.nombre + " , Daño realizado: " + enemigoEspecial1.daño + " , Vida restante: " + enemigoEspecial1.vida );
        enemigoEspecial1.ataque(); 
        enemigoEspecial1.AtaqueEspecial();
    }
    

    
}
