using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField] Button continueButton;
    [SerializeField] Button startNewButton;
    [SerializeField] Button selectLevelButton;
    [SerializeField] Button optionsButton;
    [SerializeField] Button creditsButton;


    private List<Button> buttonList;
    //IMenuController menuController;
    
    void Start()
    {
        /*AddButtonsToList();
        menuController = MenuControllerFactory.GetController();
        menuController.AddListener(buttonList);*/

        AddListenersToButtons();
        

    }

    private void AddListenersToButtons()
    {
        continueButton.onClick.AddListener(ContinueFromLastLevel);
        startNewButton.onClick.AddListener(StartLevel1);
        selectLevelButton.onClick.AddListener(OpenSelectLevelMenu);
        optionsButton.onClick.AddListener(OpenOptionsMenu);
        creditsButton.onClick.AddListener(OpenCreditScene);
    }

    private void OpenCreditScene()
    {
        throw new NotImplementedException();
    }

    private void OpenOptionsMenu()
    {
        throw new NotImplementedException();
    }

    private void OpenSelectLevelMenu()
    {
        throw new NotImplementedException();
    }

    private void StartLevel1()
    {
        SceneManager.LoadScene(1);
    }

    private void ContinueFromLastLevel()
    {
        throw new NotImplementedException();
    }



    /*private void AddButtonsToList()
    {
        buttonList.Add(continueButton);
        buttonList.Add(startNewButton);
        buttonList.Add(selectLevelButton);
        buttonList.Add(optionsButton);
        buttonList.Add(creditsButton);
    }
    
    static class MenuControllerFactory
    {
        public static IMenuController GetController()
        {
            IMenuController controller = new PCController();

            return controller;
        }
    }

    public interface IMenuController
    {
        void AddListener(List<Button> buttonList);
        
    }

    public class PCController : IMenuController
    {
        public void AddListener(List<Button> buttonList)
        {
            foreach(Button button in buttonList)
            {
                button.onClick.AddListener();
            }
        }        
        
    }*/
}
