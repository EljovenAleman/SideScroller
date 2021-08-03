using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D player;

    public GameObject duplicatedPlayer;
    public Collider2D duplicatedPlayerCollider;

    public bool isPlayerAlive = true;
    public bool isPlayerInControl = true;
    public bool isPlayerDuplicated = false;
    public bool isPlayerBouncing = false;
    public float lateralSpeed = 0.1f;
    private float bounceForce = 2f;
    
    public Vector3 direction;
    IController playerController;

    [SerializeField] float xGravity;
    [SerializeField] float yGravity;

    private void Awake()
    {
        playerController = ControllerFactory.GetController();
        duplicatedPlayerCollider = duplicatedPlayer.GetComponent<Collider2D>(); 
    }


    void Start()
    {
        player = GetComponent<Rigidbody2D>();        
    }

    
    void FixedUpdate()
    {
        
        if(isPlayerInControl)
        {
            player.transform.position = new Vector3(player.transform.position.x + lateralSpeed, player.transform.position.y, player.transform.position.z);
            playerController.CheckForButtonPressToPushPlayerUp(player);                
        }
        else if(isPlayerBouncing)
        {
            player.AddForce(direction * bounceForce, ForceMode2D.Impulse);
        }
        else
        {
            player.transform.position = new Vector3(player.transform.position.x + lateralSpeed, player.transform.position.y, player.transform.position.z);
        }
        
    }
}

static class ControllerFactory
{

    public static IController GetController()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        IController controller = new PCController();

#elif UNITY_ANDROID || UNITY_IOS
        IController controller = new MobileController();

#endif

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
    //upwardsForce = 25f (con Time.deltaTime)
    public float upwardsForce = 0.5f;
    public float rotationSpeedCap = 100;

    public void CheckForButtonPressToPushPlayerUp(Rigidbody2D player)
    {
        if(Input.GetKey("space"))
        {            
            player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
            player.AddTorque(1f, ForceMode2D.Force);
          
            Debug.Log(player.rotation);
        }        
        
    }


    public void ReleasePlayer()
    {
        throw new System.NotImplementedException();
    }
}

public class MobileController : IController
{
    public float upwardsForce = 0.5f;

    public void CheckForButtonPressToPushPlayerUp(Rigidbody2D player)
    {
        if(Input.touchCount > 0)
        {
            player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
            player.AddTorque(1f, ForceMode2D.Force);
        }
    }

    public void ReleasePlayer()
    {
        throw new System.NotImplementedException();
    }
}
