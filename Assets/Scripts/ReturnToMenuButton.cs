using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMenuButton : MonoBehaviour
{
    [SerializeField] Button returnToMenuButton;
    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
    }

   
}
