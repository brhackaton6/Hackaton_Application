using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject optionMenu;
    [SerializeField] private GameObject optionMenuBG;
    [SerializeField] private GameObject bakuKartMenu;
    [SerializeField] private GameObject addCardMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject accountsMenu;
    [SerializeField] private GameObject cashPopUpMenu;
    [SerializeField] public Camera camera;
    [SerializeField] private TMP_InputField cardNumberInput;
    [SerializeField] private TMP_InputField cardTitleInput;
    [SerializeField] private TMP_InputField cardBalanceInput;
    [SerializeField] private TMP_Text accountCardTitle;
    [SerializeField] private TMP_Text cardBalanceText;
    [SerializeField] private TMP_Text cardBalanceTextAcc;

    private int cardBalance;

    private string cardNumber;
    private string cardTitle;



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
        cashPopUpMenu.SetActive(false);
        bakuKartMenu.SetActive(false);
        accountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        mainMenu.SetActive(true);
    }


    public void AddBakiKart()
    {
        accountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        accountsMenu.SetActive(false);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        mainMenu.SetActive(true);

    }

    public void ToAccountsMenu()
    {
        accountsMenu.SetActive(true);
        optionMenu.SetActive(false);
        optionMenuBG.SetActive(false);
        addCardMenu.SetActive(false);
        mainMenu.SetActive(false);

    }

    public void OnProceedButton()
    {
        cardNumber = cardNumberInput.text;
        cardTitle = cardTitleInput.text;
        addCardMenu.SetActive(false);
        mainMenu.SetActive(true);
        cardNumberInput.text = "";
        cardTitleInput.text = "";
        accountCardTitle.text = cardTitle;
        
    }

    public void ToBakuKartMenu()
    {
        accountsMenu.SetActive(false);
        bakuKartMenu.SetActive(true);
    }

    public void ToPaymentMenu()
    { 
        cashPopUpMenu.SetActive(true);
    }

    public void PayButton()
    {
        cardBalance += int.Parse(cardBalanceInput.text);
        cardBalanceText.text = cardBalance.ToString();
        cardBalanceTextAcc.text = cardBalance.ToString();
        cashPopUpMenu.SetActive(false);

    }

    public void BackToAccountMenu()
    {
        bakuKartMenu.SetActive(false);
        accountsMenu.SetActive(true);
    }
}

