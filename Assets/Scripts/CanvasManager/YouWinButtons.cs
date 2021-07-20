﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinButtons : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    [SerializeField] Button nextLevelButton;

    PlayerPrefsDataManager dataManager;
    
    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        dataManager = FindObjectOfType<PlayerPrefsDataManager>();
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        nextLevelButton.onClick.AddListener(dataManager.SetCurrentLevelToNextThenLoadIt);
    }
}