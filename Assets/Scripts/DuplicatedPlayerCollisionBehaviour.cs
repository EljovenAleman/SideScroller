using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatedPlayerCollisionBehaviour : MonoBehaviour
{
    ParticleSystem myParticleSystem;

    PlayerMovement player;
    DuplicatedPlayerBehaviour duplicatedPlayer;

    //Audio
    AudioSource objectSound;


    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        duplicatedPlayer = GetComponent<DuplicatedPlayerBehaviour>();
    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "TopAndBottomLimit")
        {
            DisablePlayerComponents();


            player.isPlayerInControl = false;

            objectSound = gameObject.GetComponent<AudioSource>();
            objectSound.Play();

        }
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bouncer")
        {
            myParticleSystem = collision.GetComponent<ParticleSystem>();
            myParticleSystem.Play();
        }
        /*
        else if (collision.gameObject.tag == "LandingSpot")
        {
            duplicatedPlayer.isPlayerInControl = true;

        }
        else if (collision.gameObject.tag == "Duplicator")
        {
            if (duplicatedPlayer.isPlayerDuplicated == false)
            {
                duplicatedPlayer.isPlayerDuplicated = true;
                Instantiate(duplicatedPlayer.duplicatedPlayer);
            }
        }
        else if (collision.gameObject.tag == "Singularizer")
        {
            if (duplicatedPlayer.isPlayerDuplicated)
            {
                duplicatedPlayer.isPlayerDuplicated = false;
                Destroy(GameObject.FindGameObjectWithTag("DuplicatedPlayer"));
            }
        }*/
    }

    private void DisablePlayerComponents()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<TrailRenderer>().enabled = false;
    }

    
}
