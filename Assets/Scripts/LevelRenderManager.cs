using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRenderManager : MonoBehaviour
{
    private Camera myCamera;
    private GameObject[] obstaclesList;
    void Start()
    {
        myCamera = GameObject.FindObjectOfType<Camera>();
        obstaclesList = new GameObject[0];
        obstaclesList = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    
    void Update()
    {
        foreach(GameObject obstacle in obstaclesList)
        {
            var distance = Vector2.Distance(myCamera.transform.position, obstacle.transform.position);
            Debug.Log(distance);
            if (distance >= 20)
            {
                obstacle.SetActive(false);
            }
            else
            {
                obstacle.SetActive(true);
            }
        }
        
        //var data = myCamera.ViewportPointToRay(myCamera.transform.position);
        
    }
}
