using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int pay;
    private int hundreds;
    //public int fifties;
    private int twenties;
    private int tens;
    private int fives;
    private int ones;
    private int hundredsRemainder;
    private int fiftiesRemainder;
    private int twentiesRemainder;
    private int tensRemainder;
    private int fivesRemainder;
    private int onesRemainder;

    // Start is called before the first frame update
    void Start()
    {
        countingChange(pay);
    }

    void countingChange(int pay)
    {
        //Counts hundreds
        int hundreds = pay / 100;
        int hundredsRemainder = (pay % 100);
        //if pay is less than $100 it sets the remainder value to the value of pay for it to then go to the 50's
        if (pay < 100) 
        {
            hundreds = 0;
            hundredsRemainder = pay;
        }

        int fifties = hundredsRemainder / 50;
        int fiftiesRemainder = (hundredsRemainder % 50);

        int twenties = fiftiesRemainder / 20;
        int twentiesRemainder = (fiftiesRemainder % 20);

        int tens = twentiesRemainder / 10;
        int tensRemainder = (twentiesRemainder % 10);

        int fives = tensRemainder / 5;
        int fivesRemainder = (tensRemainder % 5);

        int ones = fivesRemainder / 1;
        int onesRemainder = (fivesRemainder % 1);
       
        print("If I get paid " + pay + "$ I will get " + hundreds + " $100's, " + fifties + " $50's, " + twenties + " $20's, "
        + tens + " $10's, " + fives + " $5's, " + ones + " $1's.");
    }
}
