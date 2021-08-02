using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerAudio : MonoBehaviour
{
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
}
