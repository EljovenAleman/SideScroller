using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviourOnSelect : MonoBehaviour
{
    [SerializeField] Button button;
    //[SerializeField] AudioSource myAudio;



    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        button.image.color = new Color(255, 0, 0);
        //myAudio.Play();
    }
}
