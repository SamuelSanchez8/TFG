using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public float velocidad;
    private Rigidbody2D rigidBody;
    public float fuerzaSalto;
    private SpriteRenderer flip;
    public AudioSource audio;
      
    public GameObject panel;
    public Animator animator;
    public GameObject arma;
    public GameObject muerte;
    float xInicial, yInicial;
    public AudioSource atacarau;


    void Start(){ //se ejecuta una sola vez al principio

        velocidad = 7f;
        rigidBody = GetComponent<Rigidbody2D>();
        fuerzaSalto = 0f;
        flip = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        muerte = GameObject.FindGameObjectWithTag("muerte");
        xInicial = transform.position.x;
        yInicial = transform.position.y;
    }

    
    void Update() //se ejecuta por cada frame durante el juego
    {
        arma.SetActive(false);
        // MOVIMIENTO
        if (Input.GetAxis("Horizontal") > 0){
            //transform.localScale = new Vector3(1, 1, 1);
            flip.flipX = false;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            //  transform.localScale = new Vector3(-1, 1, 1);
            flip.flipX = true;
        }

        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0)*velocidad*Time.deltaTime;

        //SALTO
        if (Input.GetMouseButtonDown(0)){
            rigidBody.AddForce(Vector2.up*fuerzaSalto, ForceMode2D.Impulse);
            audio.Play();
        }
        
        // ATACAR
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Atacar");
            arma.SetActive(true);
            atacarau.Play();

        }
    }


    public void Recolocar()
    {
        transform.position = new Vector3(xInicial,yInicial,0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Colmillo")
        {
            GetComponentInChildren<Camera>().transform.parent = null;
            GetComponentInChildren<ParticleSystem>().Play();
            GetComponentInChildren<ParticleSystem>().transform.parent = null;

            muerte.SendMessage("audioMuerte");
            Destroy(gameObject);
	        panel.SetActive(true);
        }
    }



}
