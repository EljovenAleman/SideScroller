using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLoseButtons : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    [SerializeField] Button screenButton;
    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {

        levelLoadingPresenter = new LevelLoadingPresenter();
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        screenButton.onClick.AddListener(levelLoadingPresenter.LoadCurrentLevel);

    }

    
    
}
