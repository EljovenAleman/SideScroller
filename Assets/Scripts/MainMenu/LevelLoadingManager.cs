using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


//Model
public static class LevelLoadingManager
{
    //este int es public solo por test
    public static int currentLevel = 0;
    
    public static void StartGame()
    {
        //testing
        //SceneManager.LoadScene(6);
        currentLevel = 1;
        SceneManager.LoadScene(1);
    }

    public static void GoToMainMenu()
    {
        currentLevel = 0;
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
        currentLevel += 1;
    }
        
}

//Presenter
public class LevelLoadingPresenter
{
    public BackgroundMusicPresenter backgroundMusicPresenter;
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


