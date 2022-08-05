using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject optionMenu;
    [SerializeField] GameObject optionMenuBG;
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
    }

}

