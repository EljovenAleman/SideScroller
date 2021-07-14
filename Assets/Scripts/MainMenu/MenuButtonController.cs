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
    PlayerPrefsDataManager dataManager;

               
    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        dataManager = FindObjectOfType<PlayerPrefsDataManager>();
        AddListenersToButtons();        
    }

    private void AddListenersToButtons()
    {
        startNewButton.onClick.AddListener(dataManager.SetCurrentLevelToOneThenLoadIt);
        continueButton.onClick.AddListener(levelLoadingPresenter.LoadCurrentLevel);
    }

    



    
}
