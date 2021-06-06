using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class filosofal : MonoBehaviour
{

    public float velocidad;
    public GameObject Gmpiedra;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("PreEscena2");
    }
}
