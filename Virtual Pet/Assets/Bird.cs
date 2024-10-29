using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Pet
{
    public int wingSpan;

    public int CalculateHumanYears()
    { return age * 10; }

    public string GetInfo()
    {
        return "Name: " + name +
                "\nAge: " + age +
                "\nHappiness: " + happinessLevel +
                "\nEnergy: " + energyLevel +
                "\nWingSpan: " + wingSpan;
    }
}

