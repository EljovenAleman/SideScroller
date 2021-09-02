using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{

    [SerializeField] public AudioSource basicMusic;
    [SerializeField] public AudioSource bouncerMusic;
    [SerializeField] public AudioSource duplicatorMusic;
    [SerializeField] public AudioSource speederMusic;

    private List<AudioSource> trackList = new List<AudioSource>();


    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if(objects.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        trackList.Add(basicMusic);
        trackList.Add(bouncerMusic);
        trackList.Add(duplicatorMusic);
        trackList.Add(speederMusic);
    }

    public void ManageVolume(List<AudioSource> trackListToTurnVolumeOn)
    {
        foreach(AudioSource track in trackList)
        {
            if(trackListToTurnVolumeOn.Contains(track))
            {
                track.volume = 1;
            }
            else
            {
                track.volume = 0;
            }
        }
    }

    /*public void TurnVolumeOff(AudioSource track)
    {
        track.volume = 0;
    }*/

}
