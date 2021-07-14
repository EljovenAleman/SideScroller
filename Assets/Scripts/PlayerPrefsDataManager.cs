using UnityEngine;

public class PlayerPrefsDataManager : MonoBehaviour
{
    LevelLoadingPresenter levelLoadingPresenter;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        GetCurrentLevel();
    }

    private void GetCurrentLevel()
    {
        levelLoadingPresenter.SetCurrentLevel(PlayerPrefs.GetInt("CurrentLevel", 1));
    }

    public void SetCurrentLevelToNextThenLoadIt()
    {
        Debug.Log("The current level is:" + LevelLoadingManager.currentLevel);
        PlayerPrefs.SetInt("CurrentLevel", levelLoadingPresenter.GetCurrentLevel() + 1);
        levelLoadingPresenter.LoadNextLevel();
    }

    public void SetCurrentLevelToOneThenLoadIt()
    {
        PlayerPrefs.SetInt("CurrentLevel", 1);
        levelLoadingPresenter.StartNewGame();
    }
}


