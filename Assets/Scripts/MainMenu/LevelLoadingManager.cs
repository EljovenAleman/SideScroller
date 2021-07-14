using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


//Model
public static class LevelLoadingManager
{
    //este int es public solo por test
    public static int currentLevel = 1;
    
    public static void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public static void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public static void LoadCurrentLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public static int GetCurrentLevel()
    {
        return currentLevel;
    }

    public static void SetCurrentLevel(int _currentLevel)
    {
        currentLevel = _currentLevel;
    }

    public static void LoadNextLevel()
    {                
        SceneManager.LoadScene(currentLevel + 1);
    }
        
}

//Presenter
public class LevelLoadingPresenter
{
    public void StartNewGame()
    {
        LevelLoadingManager.StartGame();
    }

    public void GoToMainMenu()
    {
        LevelLoadingManager.GoToMainMenu();
    }

    public void LoadCurrentLevel()
    {
        LevelLoadingManager.LoadCurrentLevel();
    }

    public int GetCurrentLevel()
    {
        return LevelLoadingManager.GetCurrentLevel();
    }

    public void SetCurrentLevel(int _currentLevel)
    {
        LevelLoadingManager.SetCurrentLevel(_currentLevel);
    }

    public void LoadNextLevel()
    {
        LevelLoadingManager.LoadNextLevel();
    }
}


