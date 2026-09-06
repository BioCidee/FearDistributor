using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistributorSystem : MonoBehaviour
{
    private float price;
    private float currntMoney;

    private bool isPlayerChosseAProduct = false;
    private bool isPlayerHaveEnoughCoin = false;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI playerMonneyUI;
    
    [SerializeField] private SO_BaseProduit currentProduct;
    [SerializeField] private string sellTextString = "The price is : ";
    [SerializeField] private string playerMonneyString = "You have : ";
    private float currentPlayerMonney = 0;

    [SerializeField] private SO_BaseProduit chocolate;
    [SerializeField] private SO_BaseProduit chips;
    [SerializeField] private List<SO_BaseProduit> listProduct = new List<SO_BaseProduit>();

    void Update()
    {
        if (isPlayerChosseAProduct)
        {
            
        }
        else
        {
            return;
        }
    }

    private void SetCurrentProduct(SO_BaseProduit _newCurrentProduit)
    {
        if(_newCurrentProduit == null) Debug.LogError("there is no new current product");

        currentProduct = null;
        currentProduct = _newCurrentProduit;

        text.text = sellTextString + currentProduct.price;
        playerMonneyUI.text = playerMonneyString + currentPlayerMonney.ToString();

    }

    public void GetChocolate()
    {
        SetCurrentProduct(chocolate);
    }

    public void GetChips()
    {
        SetCurrentProduct(chips);
    }

    private void UpdatePlayerCoin()
    {
        playerMonneyUI.text = playerMonneyString + currentPlayerMonney.ToString();
    }

    public void Add1Coin()
    {
        currentPlayerMonney++;
        UpdatePlayerCoin();
    }

    public void Add2Coin()
    {
        currentPlayerMonney += 2;
        UpdatePlayerCoin();
    }

    public void Add1DemiCoin()
    {
        currentPlayerMonney += 0.5f;
        UpdatePlayerCoin();
    }
}
