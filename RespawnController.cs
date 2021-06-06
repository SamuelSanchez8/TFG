using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour

   
{
    public GameObject enemy;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CrearEnemigos");
    }

    IEnumerator CrearEnemigos()
    {
        yield return new WaitForSeconds(20f);
        while (true)
        {
            Instantiate(enemy, transform.position, enemy.transform.rotation);
            yield return new WaitForSeconds(Random.Range(15,20));
        }
    }
    public void CancelarEnemigos()
    {
        StopCoroutine("CrearEnemigos");
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemigos.Length; i++)
        {
            Destroy(enemigos[i]);
        }
        StartCoroutine("FinJuego");

    }
    IEnumerator FinJuego()
    {
        yield return new WaitForSeconds(1.5f);
        panel.SetActive(true);
    }
}
