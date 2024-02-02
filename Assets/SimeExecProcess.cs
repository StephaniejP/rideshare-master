using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;


public class SimeExecProcess : MonoBehaviour ///Initializations
{
    //Initialize global variables

   [SerializeField] public int rider_ID;
   public int numOfRiders = 10;
   public double TipAmount;
   private Riders[] Rider;
    public double Earnings;
    public int Rating;

   // Start is called before the first frame update
    void Start()
    {
        InitializeRider();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeRider()
    {
        Rider = GenerateRiders(numOfRiders);
    }

  private Riders[] GenerateRiders(int numOfRiders) 
    {
        Riders[] riders = new Riders[numOfRiders];
        System.Random rand = new System.Random();

        for(int i = 0; i < numOfRiders; i++) 
        {
            double tip = 5 + rand.NextDouble() * (30 - 5); // Generate random tip amount between $5 and $30 in c#
            int rating = 1 + UnityEngine.Random.Range(1,6); // Generate random rating between 1 and 5 (inclusive)

            Riders rider = new Riders // Create a new rider and assign attributes 
            {
                rider_ID = i + 1, 
                TipAmount = tip,
                Rating = rating
            };

            riders[i] = rider;
        }
       
       return riders;
    }
}

[Serializable]
public class Riders
{
    public int rider_ID;
    public double TipAmount;
    public int Rating;

}