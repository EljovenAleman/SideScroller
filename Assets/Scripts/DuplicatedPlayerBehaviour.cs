using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatedPlayerBehaviour : MonoBehaviour
{
    PlayerMovement player;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y * -1, player.transform.position.z);
        transform.rotation = player.transform.rotation;
    }
}
