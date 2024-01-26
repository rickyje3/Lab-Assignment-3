using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public int bookCost;
    public int copies;
    private int shippingFirst = 3;
    private decimal shippingPastOne = .75m;

    // Start is called before the first frame update
    void Start()
    {
        Total();
    }


    public void Total()
    {
        int discountedBook = (int)(bookCost * 0.6); //What the store buys the books for
        int discountedShipping = (int)(copies - 1); //The copies that get charges .75c shipping
        int totalWholesaleCost = (int)(discountedBook * copies + shippingFirst + shippingPastOne * discountedShipping);
        int totalProfits = (int)((bookCost * copies) - (discountedBook * copies) + shippingFirst + shippingPastOne * discountedShipping); 
        print("For " + copies + " copies of a " + bookCost + "$ book, the total wholesale cost is " + totalWholesaleCost +"$ and the profit is " + totalProfits + "$");
    }
}
