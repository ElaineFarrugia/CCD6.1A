using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    public int barkingLevel;

    public int CalculateHumanYears()
        { return age * 7; }

    public string GetInfo()
    {
        return "Name: " + name +
                "\nAge: " + age +
                "\nHappiness: " + happinessLevel +
                "\nEnergy: " + energyLevel +
                "\nBarking Level: " + barkingLevel;
    }
}
