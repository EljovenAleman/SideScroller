using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMenuButton : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    LevelLoadingPresenter levelLoadingPresenter;
    BackgroundMusicPresenter backgroundMusicPresenter;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        backgroundMusicPresenter = FindObjectOfType<BackgroundMusicPresenter>();
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        returnToMenuButton.onClick.AddListener(() => backgroundMusicPresenter.CollectTracksAndSendToManager());
    }

   
}
