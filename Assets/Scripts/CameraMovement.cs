using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    private void Start()
    {
        
    }

    void Update()
    {
        new Vector3(0,0,0);
        transform.position = new Vector3(playerTransform.position.x + 5, transform.position.y, transform.position.z);
    }
}
