using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Pet
{
    private int wingSpan;

    public Bird() { } //parameter-less constructor

    public Bird(string name, int age, int happinessLevel, int energyLevel,
                int wingSpan) : base(name, age, happinessLevel, energyLevel)
    {
        this.wingSpan = wingSpan;
    }

    //setter
    public void SetWingSpan(int NewWingSpan)
    { wingSpan = NewWingSpan; }

    //getter
    public int GetWingSpan()
    { return wingSpan; }

    public int CalculateHumanYears()
    { return GetAge() * 10; }

    public override void play()
    {
        SetEnergyLevel(GetEnergyLevel() - 2);
        SetHappinessLevel(GetHappinessLevel() + 1);
    }

    //the "new" keyword means we are
    //rewriting a method that already
    //exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() +
                "\nWingSpan: " + wingSpan;
    }
}

