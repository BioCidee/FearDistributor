using System.Collections.Generic;
using UnityEngine;

public class DistributorSystem : MonoBehaviour
{
    private float price;
    private float currntMoney;
    
    [SerializeField] private SO_BaseProduit currentProduct;

    [SerializeField] private SO_BaseProduit chocolate;
    [SerializeField] private SO_BaseProduit chips;
    [SerializeField] private List<SO_BaseProduit> listProduct = new List<SO_BaseProduit>();

    private void SetCurrentProduct(SO_BaseProduit _newCurrentProduit)
    {
        if(_newCurrentProduit == null) Debug.LogError("there is no new current product");

        currentProduct = null;
        currentProduct = _newCurrentProduit;
    }

    public void GetChocolate()
    {
        SetCurrentProduct(chocolate);
    }

    public void GetChips()
    {
        SetCurrentProduct(chips);
    }
}
