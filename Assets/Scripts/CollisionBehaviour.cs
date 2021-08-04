using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    ParticleSystem myParticleSystem;
    LevelLoadingPresenter levelLoadingPresenter;
    CameraMovement gameCamera;
    PlayerMovement player;
    CanvasManager canvasManager;

    //Audio
    AudioSource objectSound;

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
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "TopAndBottomLimit")
        {
            player.isPlayerInControl = false;
            DisablePlayerComponents();
            
            StartCoroutine(OnPlayerDeath());
            player.isPlayerAlive = false;

            objectSound = gameObject.GetComponent<AudioSource>();
            objectSound.Play();
            myParticleSystem = gameObject.GetComponent<ParticleSystem>();
            myParticleSystem.Play();

        }        
        else if(collision.gameObject.tag == "WinThreshold")
        {
            gameObject.SetActive(false);
            canvasManager.ShowYouWinScreen();
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bouncer")
        {
            var direction = collision.gameObject.transform.Find("LandingSpot").transform.position - player.transform.position;
            direction = direction.normalized;

            player.direction = direction;
            player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            player.isPlayerInControl = false;
            player.isPlayerBouncing = true;

            objectSound = collision.gameObject.GetComponent<AudioSource>();
            objectSound.Play();
            myParticleSystem = collision.GetComponent<ParticleSystem>();
            myParticleSystem.Play();

            Debug.Log(direction);
        }
        else if(collision.gameObject.tag == "LandingSpot")
        {
            player.isPlayerInControl = true;
            player.isPlayerBouncing = false;
            
        }
        else if(collision.gameObject.tag == "Duplicator")
        {
            if(player.isPlayerDuplicated == false)
            {
                player.isPlayerDuplicated = true;
                Instantiate(player.duplicatedPlayer);
            }
        }
        else if(collision.gameObject.tag == "Singularizer")
        {
            if(player.isPlayerDuplicated)
            {
                player.isPlayerDuplicated = false;
                Destroy(GameObject.FindGameObjectWithTag("DuplicatedPlayer"));
            }
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
