using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{

    public Transform target;
    public float velocidad;
    private Vector3 start, end;



    // Start is called before the first frame update
    void Start()
    {
        velocidad = 3f;
        start = transform.position;
        end = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, velocidad*Time.deltaTime);
        if(transform.position == target.position)
        {
            if(target.position == start)
            {
                target.position = end;
            }
            else
            {
                target.position = start;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D colision){

        colision.transform.parent = transform;
    }

    void OnCollisionExit2D(Collision2D colision)
    {
        colision.transform.parent = null;
    }
}
