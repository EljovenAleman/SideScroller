using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusicManager : MonoBehaviour
{
    [SerializeField] AudioSource mainMusic;

    [SerializeField] AudioSource mainMusicLoop;

    bool loppingMusic = false;
    
    
    void Update()
    {
        if(mainMusic.isPlaying == false && loppingMusic == false)
        {
            loppingMusic = true;
            mainMusicLoop.Play();
        }
    }
}
