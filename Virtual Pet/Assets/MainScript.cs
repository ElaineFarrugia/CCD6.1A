using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type    
    Bird b; //Bird is a data type
    public Text dogInfo, birdInfo;
    public Button btnDogPlay, btnDogSleep, btnDogFeed;
    public Button btnPlayAll;
    public Button btnBirdPlay, btnBirdSleep, btnBirdFeed;
    List<Pet> pets = new List<Pet>();

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog("Ginger", 1, 5, 5, 5);
        pets.Add(d); //add new dog to the list

        //d.SetName("Ginger");
        //d.SetAge(1);
        //d.SetHappinessLevel(5);
        //d.SetEnergyLevel(5);
        //d.SetBarkingLevel(5);

        b = new Bird("Skye", 4, 5, 5, 20);
        pets.Add(b); //add new bird to the list

        //b = new Bird();
        //b.SetName("Skye");
        //b.SetAge(4);
        //b.SetHappinessLevel(5);
        //b.SetEnergyLevel(5);
        //b.SetWingSpan(20);        

        btnDogPlay.GetComponent<Button>().onClick.AddListener(dogPlayEvent);
        btnDogFeed.GetComponent<Button>().onClick.AddListener(dogFeedEvent);
        btnDogSleep.GetComponent<Button>().onClick.AddListener(dogSleepEvent);

        btnBirdPlay.GetComponent<Button>().onClick.AddListener(birdPlayEvent);
        btnBirdFeed.GetComponent<Button>().onClick.AddListener(birdFeedEvent);
        btnBirdSleep.GetComponent<Button>().onClick.AddListener(birdSleepEvent);

        btnPlayAll.GetComponent<Button>().onClick.AddListener(playAllEvent);
    }

    void playAllEvent()
    {
        foreach (Pet pet in pets)
        {
            pet.play(); //polymorphism
        }
    }

    void dogPlayEvent()
    {
        d.play();
    }

    void dogFeedEvent()
    {
        d.feed();
    }

    void dogSleepEvent()
    {
        d.sleep();
    }

    void birdPlayEvent()
    {
        b.play();
    }

    void birdFeedEvent()
    {
        b.feed();
    }

    void birdSleepEvent()
    {
        b.sleep();
    }

    // Update is called once per frame
    void Update()
    {
        dogInfo.text = d.GetInfo(); 
        birdInfo.text = b.GetInfo();
    }
}
