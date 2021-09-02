using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//View
public class MenuButtonController : MonoBehaviour
{    
    [SerializeField] Button startNewButton;
    [SerializeField] Button continueButton;
    LevelLoadingPresenter levelLoadingPresenter;
    BackgroundMusicPresenter backgroundMusicPresenter;
    PlayerPrefsDataManager dataManager;

               
    void Start()
    {
        backgroundMusicPresenter = FindObjectOfType<BackgroundMusicPresenter>();
        levelLoadingPresenter = new LevelLoadingPresenter();
        dataManager = FindObjectOfType<PlayerPrefsDataManager>();
        AddListenersToButtons();        
    }

    public void AddListenersToButtons()
    {
        
        startNewButton.onClick.AddListener(dataManager.SetCurrentLevelToOneThenLoadIt);
        startNewButton.onClick.AddListener(() => backgroundMusicPresenter.CollectTracksAndSendToManager());


        continueButton.onClick.AddListener(levelLoadingPresenter.LoadCurrentLevel);
        continueButton.onClick.AddListener(() => backgroundMusicPresenter.CollectTracksAndSendToManager());

    }

    



    
}
