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
    LevelLoadingPresenter levelLoadingPresenter;

               
    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        AddListenersToButtons();        
    }

    private void AddListenersToButtons()
    {
        startNewButton.onClick.AddListener(levelLoadingPresenter.StartGame);
    }

    



    
}
