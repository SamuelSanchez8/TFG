﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copa : MonoBehaviour
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
    public void audioCopa()
    {
        audio.Play();
    }
}