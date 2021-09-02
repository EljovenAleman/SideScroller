using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicPresenter : MonoBehaviour
{    
    List<AudioSource> trackList = new List<AudioSource>();
    BackgroundMusicManager musicManager;

    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {
        musicManager = FindObjectOfType<BackgroundMusicManager>();
        levelLoadingPresenter = new LevelLoadingPresenter();        
    }

    public void CollectTracksAndSendToManager()
    {
        int currentLevel = levelLoadingPresenter.GetCurrentLevel();
        Debug.Log(currentLevel);
        trackList.Clear();

        if(currentLevel >= 1)
        {
            trackList.Add(musicManager.basicMusic);
        }
        if(currentLevel >= 2)
        {
            trackList.Add(musicManager.bouncerMusic);
        }
        if(currentLevel >= 3)
        {
            trackList.Add(musicManager.duplicatorMusic);
        }
        if(currentLevel >= 4)
        {
            trackList.Add(musicManager.speederMusic);
        }
        else if(currentLevel == 0)
        {
            
        }

        musicManager.ManageVolume(trackList);
        
    }

    public void TestMethod()
    {

    }
}
