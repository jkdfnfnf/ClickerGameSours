using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public int Money;
    private int MoneyUp = 1;
    private bool Check = true;
    public Text MoneyText;
    public Text MoneyText2;
    public Text MoneyText3;
    public GameObject ShopPanel;
    
    public int LimitDoubleUp = 100;
    
    void Update()
    {
        MoneyText.text = Money + "$";
        MoneyText2.text = Money + "$";
        MoneyText3.text = "Double Click " + LimitDoubleUp + "$";
    }
    public void OnClickButton()
    {
        Money += MoneyUp;
    }

    public void OnClickShopButton()
    {
        if (Check == true)
        {
            ShopPanel.SetActive(true);
            Check = false;
        }
        else
        {
            ShopPanel.SetActive(false);
            Check = true;
        }
    }

    public void OnClickBuy()
    {
        if (Money >= LimitDoubleUp)
        {
            MoneyUp *= 2;
            Money -= LimitDoubleUp;
            LimitDoubleUp *= 2;
        }
    }
}
