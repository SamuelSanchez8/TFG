using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fin6 : MonoBehaviour
{

    public float velocidad;
    public GameObject Gmpiedra;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("PreEscena7");
    }
}
