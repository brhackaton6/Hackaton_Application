using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject optionMenu;
    [SerializeField] private GameObject optionMenuBG;
    [SerializeField] private GameObject addCardMenu;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject AccountsMenu;
    [SerializeField] public Camera camera;

    

    public void OnPlusButton()
    {
        optionMenu.SetActive(true);
        optionMenuBG.SetActive(true);


    }


    public void CloseOptionMenu()
    {
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
    }
    public void Start()
    {
        AccountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        MainMenu.SetActive(true);
    }


    public void AddBakiKart()
    {
        AccountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        AccountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        MainMenu.SetActive(true);

    }

    public void ToAccountsMenu()
    {
        AccountsMenu.SetActive(true);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        MainMenu.SetActive(false);

    }
}

