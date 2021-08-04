using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerAudio : MonoBehaviour
{
    public AudioSource myAudio;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }
}
