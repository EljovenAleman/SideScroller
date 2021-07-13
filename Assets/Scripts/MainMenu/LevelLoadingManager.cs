using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Model
public static class LevelLoadingManager
{
    private static int currentLevel = 1;

    public static void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public static void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public static void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }
    
}

//Presenter
public class LevelLoadingPresenter
{
    public void StartGame()
    {
        LevelLoadingManager.StartGame();
    }

    public void GoToMainMenu()
    {
        LevelLoadingManager.GoToMainMenu();
    }

    public void ReloadCurrentLevel()
    {
        LevelLoadingManager.ReloadCurrentLevel();
    }
}


