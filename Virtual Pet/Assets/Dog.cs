public class Dog : Pet
{
    private int barkingLevel;

    public Dog() { } //parameter-less constructor

    public Dog(string name, int age, int happinessLevel, int energyLevel,
                int barkingLevel) : base(name,age,happinessLevel,energyLevel)
    {        
        this.barkingLevel = barkingLevel;
    }

    //getter
    public int GetBarkingLevel()
    { return barkingLevel; }

    //setter
    public void SetBarkingLevel(int NewBarkingLevel)
    { barkingLevel = NewBarkingLevel; }

    public override void play()
    {
        SetEnergyLevel(GetEnergyLevel() - 1);
        SetHappinessLevel(GetHappinessLevel() + 2);
    }

    public int CalculateHumanYears()
    { return GetAge() * 7; }

    public new string GetInfo()
    {
        return base.GetInfo() +
                "\nBarking Level: " + barkingLevel;
    }
}
