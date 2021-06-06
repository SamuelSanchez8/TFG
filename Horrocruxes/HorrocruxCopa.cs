using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrocruxCopa : MonoBehaviour
{

    public float velocidad;
    public GameObject gameControllerCopa;

    void Start()
    {
        velocidad = 90f;
        gameControllerCopa = GameObject.FindGameObjectWithTag("GameControllerCopa");
    }

    void Update()
    {
        transform.Rotate(Vector3.down * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameControllerCopa.SendMessage("audioCopa");
            GetComponentInChildren<ParticleSystem>().Play();
            GetComponentInChildren<ParticleSystem>().transform.parent = null;
	    FindObjectOfType<PlayerController>().SendMessage("Recolocar");
            Destroy(gameObject);
        }
    }
}
