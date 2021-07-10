using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Model
public static class LevelLoadingManager
{
    static int currenLevel = 1;

    public static void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
}

//Presenter
public class LevelLoadingPresenter
{
    internal void StartGame()
    {
        LevelLoadingManager.StartGame();
    }
}


