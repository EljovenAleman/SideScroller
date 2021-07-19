using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    LevelLoadingPresenter levelLoadingPresenter;
    CameraMovement gameCamera;
    PlayerMovement player;
    CanvasManager canvasManager;

    void Start()
    {
        gameCamera = FindObjectOfType<CameraMovement>();
        player = FindObjectOfType<PlayerMovement>();
        levelLoadingPresenter = new LevelLoadingPresenter();
        canvasManager = FindObjectOfType<CanvasManager>();
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject.tag == "Obstacle")
        {
            DisablePlayerComponents();
            
            StartCoroutine(OnPlayerDeath());
            player.isPlayerAlive = false;
                        
        }
        else if(collision.gameObject.tag == "WinThreshold")
        {
            gameObject.SetActive(false);
            canvasManager.ShowYouWinScreen();
        }


    }

    private void DisablePlayerComponents()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<TrailRenderer>().enabled = false;
    }

    IEnumerator OnPlayerDeath()
    {                
        Debug.Log(gameCamera.speed);
        
        Debug.Log("Calling wait for seconds");

        yield return new WaitForSeconds(0.5f);

        Debug.Log("Waited for 1 second");
        gameCamera.speed = 0.08f;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(0.5f);

        gameCamera.speed = 0.06f;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(0.5f);

        gameCamera.speed = 0.04f;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(0.4f);

        gameCamera.speed = 0.02f;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(0.2f);

        gameCamera.speed = 0.01f;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(0.2f);

        gameCamera.speed = 0;
        Debug.Log(gameCamera.speed);

        yield return new WaitForSeconds(1);

        canvasManager.ShowYouLoseScreen();

        yield break;
    }
}
