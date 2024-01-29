using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem1 : MonoBehaviour
{
    public double modules;
    public double quizzes;
    public double readingMaterials;
    public double assignments;
    public bool hasTaught;
    // Start is called before the first frame update
    void Start()
    {
        RateChallenge();
    }

    public void RateChallenge()
    {
        //Assumption
        //The number of quizzes, assignments, and reading materials cannot be more than 1 per week (10 weeks)
        // so max for each of these values is 10
        
        modules = modules * .15;
        quizzes = quizzes * .15;
        assignments = assignments * .30;
        readingMaterials = readingMaterials * .30;

        double challengeRating = modules * quizzes * assignments * readingMaterials;

        if (hasTaught)
        {
            challengeRating += 1;
        }

        int i = Convert.ToInt32(challengeRating);
        
        print(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
