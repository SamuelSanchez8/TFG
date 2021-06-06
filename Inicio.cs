using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void Comienzo()
{
	SceneManager.LoadScene("Menu");
}

public void PreEscena1()
{
	SceneManager.LoadScene("Inicio");
}

public void Escena1()
{
	SceneManager.LoadScene("Escena1");
}

    public void Salir()
    {
        Application.Quit();
    }
}
