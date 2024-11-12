using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pet
{
    private string name;
    private int age;
    private int happinessLevel;
    private int energyLevel;

    public Pet() { } //parameter-less constructor

    public Pet(string name, int age, int happinessLevel,
                                int energyLevel)
    {
        this.name = name;
        this.age = age;
        this.happinessLevel = happinessLevel;
        this.energyLevel = energyLevel;
    }


    //getter
    public string GetName()
    { return name; }

    //setter
    public void SetName(string NewName)
    { name = NewName; }

    //getter
    public int GetAge()
    { return age; }

    //setter
    public void SetAge(int NewAge)
    {
        if (NewAge >= 0)
            age = NewAge;
    }

    public int GetHappinessLevel()
    { return happinessLevel; }

    public void SetHappinessLevel(int NewHappinessLevel)
    { happinessLevel = NewHappinessLevel; }

    public int GetEnergyLevel()
    { return energyLevel; }

    public void SetEnergyLevel(int NewEnergyLevel)
    { energyLevel = NewEnergyLevel; }

    public abstract void play();

    public void feed()
    {
        energyLevel += 1;
        happinessLevel += 1;
    }
    

    public void sleep()
    {
        energyLevel += 1;
    }

    public string GetInfo()
    {
        return "Name: " + name +
                "\nAge: " + age +
                "\nHappiness: " + happinessLevel +
                "\nEnergy: " + energyLevel;
    }
}
