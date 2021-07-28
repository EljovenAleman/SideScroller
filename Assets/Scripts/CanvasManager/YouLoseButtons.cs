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

    void Start()
    {

        levelLoadingPresenter = new LevelLoadingPresenter();
        myCamera = FindObjectOfType<Camera>();
        var myCanvas = GetComponent<Canvas>();
        myCanvas.worldCamera = myCamera;
        myCanvas.planeDistance = 9;
        returnToMenuButton.onClick.AddListener(levelLoadingPresenter.GoToMainMenu);
        screenButton.onClick.AddListener(levelLoadingPresenter.LoadCurrentLevel);

    }

    
    
}
