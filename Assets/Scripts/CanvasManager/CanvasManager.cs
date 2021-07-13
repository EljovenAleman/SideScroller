using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] GameObject youLoseCanvasPrefab;
    [SerializeField] GameObject youWinCanvasPrefab;
    [SerializeField] Transform cameraTransform;

    
    public void ShowYouLoseScreen()
    {
        youLoseCanvasPrefab.transform.position = cameraTransform.position;
        Instantiate(youLoseCanvasPrefab);
    }

    public void ShowYouWinScreen()
    {
        youWinCanvasPrefab.transform.position = cameraTransform.position;
        Instantiate(youWinCanvasPrefab);
    }
    
}
