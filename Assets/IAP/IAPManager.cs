using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPManager : MonoBehaviour
{
    private string Token50 = "com.bry.telanobela.token50";
    private string Php250 = "com.bry.telanobela.php250";

    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == Token50)
        {
            Debug.Log("You Purchased an Item");
        }

        if(product.definition.id == Php250)
        {
            Debug.Log("You Purchased a collection!");
        }
    }
    
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + "failed because" + failureReason);
    }
}
