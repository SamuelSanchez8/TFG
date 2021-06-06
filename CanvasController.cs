using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public Text texto;
	public Text UItexto;
	private int contador = 0;


private void Start()
{

	InvokeRepeating("Puntaje", 0f, 1f);
	}


void Puntaje()
{
contador++;
texto.text = "Puntos: " + contador.ToString();
}
 

    public void Reiniciar()
    {
        SceneManager.LoadScene("Escena1");
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
   



}
