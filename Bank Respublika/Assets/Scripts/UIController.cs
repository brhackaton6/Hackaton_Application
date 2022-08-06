using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject optionMenu;
    [SerializeField] GameObject optionMenuBG;
    [SerializeField] GameObject addCardMenu;
    [SerializeField] GameObject MainMenu;
    [SerializeField] Camera camera;
    RaycastHit2D hit;
    private bool GUIon;
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
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        MainMenu.SetActive(true);
    }


    public void AddBakiKart()
    {
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        MainMenu.SetActive(true);

    }
}

