using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinButtons : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    [SerializeField] Button nextLevelButton;
    private Camera myCamera;
    PlayerPrefsDataManager dataManager;
    
    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        dataManager = FindObjectOfType<PlayerPrefsDataManager>();
        myCamera = FindObjectOfType<Camera>();
        var myCanvas = GetComponent<Canvas>();
        myCanvas.worldCamera = myCamera;
        myCanvas.planeDistance = 9;

        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        nextLevelButton.onClick.AddListener(dataManager.SetCurrentLevelToNextThenLoadIt);
    }
}
