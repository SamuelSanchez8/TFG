using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController2 : MonoBehaviour
{
    	public Text texto;
	public Text PuntFinal;
	public Text UItexto;
	private int contador = 1000;

private void Start(){
	InvokeRepeating("Puntaje", 0f, 1f);
	contador = PlayerPrefs.GetInt("puntajeGuardado");
}


void Puntaje()
{
contador++;
PlayerPrefs.SetInt("puntajeGuardado", contador);
texto.text = "Puntos: " + contador.ToString();

}

 
    public void Reiniciar()
    {
        SceneManager.LoadScene("Escena1");
    }

	public void Inicio()
	{
	SceneManager.LoadScene("Inicio");
	PlayerPrefs.DeleteKey("puntajeGuardado");
	}

    public void Salir()
    {
        Application.Quit();
    }

public void ReiniciarEscena2()
    {
        SceneManager.LoadScene("Escena2");
    }

	public void ReiniciarEscena3()
    {
        SceneManager.LoadScene("Escena3");
    }

public void ReiniciarEscena7()
    {
        SceneManager.LoadScene("Escena7");
    }

public void comoJugar()
    {
        SceneManager.LoadScene("comoJugar");
    }

    void OnTriggerEnter2D()
    {			
	
        SceneManager.LoadScene("Final");
	
    }



}
