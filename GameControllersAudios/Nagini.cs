using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nagini : MonoBehaviour
{

    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void audioNagini()
    {
        audio.Play();
    }
}
