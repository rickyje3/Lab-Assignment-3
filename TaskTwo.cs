using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTwo : MonoBehaviour
{
    public int bookCost;
    public int copies;
    private int discount = bookCost * 0.6; //Bookstore discount is 40% off
    private int profit = (bookCost * 0.4 + shipping) - bookCost; //Bookstore profits off that 40%
    private int shipping;

    // Start is called before the first frame update
    void Start()
    {
        shippingCost;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    void shippingCost (int shipping) {
        if (copies == 1) {
            shipping = 3;
        }
        else if (copies >= 1) {
            shipping = 3 + 0.75 * (copies - 1);
        }
    }
}
