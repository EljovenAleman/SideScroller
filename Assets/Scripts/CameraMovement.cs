using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    PlayerMovement player;
    public float speed;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    void FixedUpdate()
    {
        if(player.isPlayerAlive)
        {            
            transform.position = new Vector3(playerTransform.position.x + 5, transform.position.y, transform.position.z);
        } 
        else
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
    }

    
}
