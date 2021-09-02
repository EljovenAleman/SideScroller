using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLoseButtons : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    [SerializeField] Button screenButton;
    private Camera myCamera;
    LevelLoadingPresenter levelLoadingPresenter;

    BackgroundMusicPresenter backgroundMusicPresenter;

    void Start()
    {

        levelLoadingPresenter = new LevelLoadingPresenter();
        backgroundMusicPresenter = FindObjectOfType<BackgroundMusicPresenter>();

        myCamera = FindObjectOfType<Camera>();
        var myCanvas = GetComponent<Canvas>();
        myCanvas.worldCamera = myCamera;
        myCanvas.planeDistance = 9;
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        returnToMenuButton.onClick.AddListener(() => backgroundMusicPresenter.CollectTracksAndSendToManager());

        screenButton.onClick.AddListener(levelLoadingPresenter.LoadCurrentLevel);

    }

    
    
}
