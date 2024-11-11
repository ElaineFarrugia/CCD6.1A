public class Dog : Pet
{
    private int barkingLevel;

    //getter
    public int GetBarkingLevel()
    { return barkingLevel; }

    //setter
    public void SetBarkingLevel(int NewBarkingLevel)
    { barkingLevel = NewBarkingLevel; }

    public int CalculateHumanYears()
    { return GetAge() * 7; }

    public new string GetInfo()
    {
        return base.GetInfo() +
                "\nBarking Level: " + barkingLevel;
    }
}
