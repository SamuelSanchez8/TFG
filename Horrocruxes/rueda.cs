using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rueda: MonoBehaviour
{

    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 40f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidad*Time.deltaTime, 0 , 0);
	
    }

}
