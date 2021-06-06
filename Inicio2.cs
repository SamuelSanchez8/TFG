using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void EscenaJuego()
{
	SceneManager.LoadScene("Escena2");
}

    public void Salir()
    {
        Application.Quit();
    }

public void EscenaJuego3()
{
	SceneManager.LoadScene("Escena3");
}

public void EscenaJuego4()
{
	SceneManager.LoadScene("Escena4");
}

public void EscenaJuego5()
{
	SceneManager.LoadScene("Escena5");
}

public void EscenaJuego6()
{
	SceneManager.LoadScene("Escena6");
}

public void EscenaJuego7()
{
	SceneManager.LoadScene("Escena7");
}

public void final()
{
	SceneManager.LoadScene("Final");
}

}
