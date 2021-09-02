using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Rigidbody2D player;
    TrailRenderer playerTrail;
    public float lateralSpeed = 0.1f;
    public float upwardsForce = 0.5f;
    float time = 0;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        playerTrail = player.GetComponent<TrailRenderer>();
    }

    
    void Update()
    {
        time += Time.deltaTime;
    }

    void FixedUpdate()
    {

        if(time< 3)
        {
            player.bodyType = RigidbodyType2D.Static;
        }
        else
        {
            player.bodyType = RigidbodyType2D.Dynamic;
        }
        
        if(time < 7.5)
        {
            //player.transform.position = new Vector3(player.transform.position.x + lateralSpeed, player.transform.position.y, player.transform.position.z);
            player.AddForce(new Vector3(0.2f, 0, 0), ForceMode2D.Impulse);
            if(time > 3.5 && time < 4)
            {
                player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
                player.AddTorque(1f, ForceMode2D.Force);
            }
            else if (time > 4.5 && time < 5)
            {
                player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
                player.AddTorque(1f, ForceMode2D.Force);
            }
            else if (time > 5.5 && time < 6.2)
            {
                player.AddForce(new Vector3(0.2f, 0, 0), ForceMode2D.Impulse);
                player.AddForce(new Vector3(0, upwardsForce, 0), ForceMode2D.Impulse);
                player.AddTorque(1f, ForceMode2D.Force);
            }            

        }
        else if (time >= 7.5 && time < 8.3)
        {
            player.drag = 0;                      
            player.transform.localScale = new Vector3(player.transform.localScale.x + 0.025f, player.transform.localScale.y + 0.025f, player.transform.localScale.z);
            playerTrail.startWidth = playerTrail.startWidth + 0.035f;
        }
        else if (time >= 8.3)
        {
            
            playerTrail.time = Mathf.Infinity;
            player.angularDrag = 0;
            player.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
