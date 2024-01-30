using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
//using System.Random;


/* public class Rider
{
    public int numOfRiders;
    public double TipAmount;

    [SerializeField] public int rider_ID;
    public int Rating;
}
 */

public class SimeExecProcess : MonoBehaviour ///Initializations
{
    // Start is called before the first frame update
    //Initialize global variables
   [SerializeField] public int rider_ID;
   // [OnSerialized] int rider_ID;
   public int numOfRiders = 10;
   public double TipAmount;
    fixed int Rider[] riders = GenerateRiders(numOfRiders);
    //pickUpLocation
    //destination()


    public double Earnings;
    public int Rating;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public int GenerateRiders(int numOfRiders) 
    {
        Random rand = new Random(); // Generate random numbers in c#
        Rider[] riders = new Rider[numOfRiders]; 

        for(int i = 0; i < numOfRiders; i++) 
        {
            double tip = 5 + rand.NextDouble() * (30 - 5); // Generate random tip amount between $5 and $30 in c#
            int rating = 1 + rand.Next(1,6); // Generate random rating between 1 and 5 (inclusive)

            Rider rider = new Rider // Create a new rider and assign attributes 
            {
                rider_ID = i + 1, 
                TipAmount = tip,
                Rating = rating
            };

            riders[i] = rider; 
        }
       
       return riders;
    }


    public void InitializeDriver()
    {
        Rating = 0; 

        ///ScheduleNext Event: RiderDecisions 
    }
}
