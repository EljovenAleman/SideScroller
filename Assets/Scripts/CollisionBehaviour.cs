using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    LevelLoadingPresenter levelLoadingPresenter;
    CanvasManager canvasManager;

    void Start()
    {
        levelLoadingPresenter = new LevelLoadingPresenter();
        canvasManager = FindObjectOfType<CanvasManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject.tag == "Obstacle")
        {
            gameObject.SetActive(false);
            canvasManager.ShowYouLoseScreen();


            //ToDo
            //StartDeathAnimation();
            //MoveTheCameraAndSlowitDownCoroutine();
            //ShowYouLoseScreen();
            //levelLoadingPresenter.GoToMainMenu();
        }
        else if(collision.gameObject.tag == "WinThreshold")
        {
            gameObject.SetActive(false);
            canvasManager.ShowYouWinScreen();
        }


    }
}
