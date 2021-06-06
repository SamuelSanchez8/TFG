using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasFinal : MonoBehaviour
{
    	public Text texto;
	public Text NuevoRecord;
	public Text PuntFinal;
	public Text UItexto;
	private int contador;
	public Text textoRecord;

private void Start(){
	
	InvokeRepeating("Puntaje", 0f, 1f);
	contador = PlayerPrefs.GetInt("puntajeGuardado");
	textoRecord.text = PlayerPrefs.GetInt("puntajeGuardado").ToString();	
	
}


void Puntaje()
{
PlayerPrefs.SetInt("puntajeGuardado", contador);

texto.text = contador.ToString();

if(contador<PlayerPrefs.GetInt("puntajeRecord",0)){

PlayerPrefs.SetInt("puntajeRecord", contador);
textoRecord.text = "¡¡Nuevo Record!!   ---   " + contador.ToString();

}


}

}