using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D player;
    public bool isPlayerAlive = true;
    private float lateralSpeed = 0.1f;
    IController playerController;

    [SerializeField] float xGravity;
    [SerializeField] float yGravity;

    private void Awake()
    {
        playerController = ControllerFactory.GetController();
    }


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    
    void FixedUpdate()
    {
        //Physics.gravity = new Vector3(xGravity, yGravity,0);
        player.transform.position = new Vector3(player.transform.position.x + lateralSpeed, player.transform.position.y, player.transform.position.z);
        playerController.CheckForButtonPressToPushPlayerUp(player);

    }
}

static class ControllerFactory
{
    public static IController GetController()
    {
        IController controller = new PCController();

        return controller;
    }
}

public interface IController
{
    void CheckForButtonPressToPushPlayerUp(Rigidbody2D player);

    void ReleasePlayer();
}

public class PCController : IController
{
    public float upwardsForce = 0.5f;
    
    public void CheckForButtonPressToPushPlayerUp(Rigidbody2D player)
    {
        if(Input.GetKey("space"))
        {
            player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
        }                
    }


    public void ReleasePlayer()
    {
        throw new System.NotImplementedException();
    }
}

public class MobileController : IController
{    
    public void CheckForButtonPressToPushPlayerUp(Rigidbody2D player)
    {
        throw new System.NotImplementedException();
    }

    public void ReleasePlayer()
    {
        throw new System.NotImplementedException();
    }
}
