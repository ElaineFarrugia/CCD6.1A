using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type    
    Bird b; //Bird is a data type
    public Text dogInfo, birdInfo;
    public Button btnDogPlay, btnDogSleep, btnDogFeed;
    public Button btnBirdPlay, btnBirdSleep, btnBirdFeed;

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog();
        d.SetName("Ginger");
        d.SetAge(1);
        d.SetHappinessLevel(5);
        d.SetEnergyLevel(5);
        d.SetBarkingLevel(5);

        b = new Bird();
        b.SetName("Skye");
        b.SetAge(4);
        b.SetHappinessLevel(5);
        b.SetEnergyLevel(5);
        b.SetWingSpan(20);

        btnDogPlay.GetComponent<Button>().onClick.AddListener(dogPlayEvent);
        btnDogFeed.GetComponent<Button>().onClick.AddListener(dogFeedEvent);
        btnDogSleep.GetComponent<Button>().onClick.AddListener(dogSleepEvent);

        btnBirdPlay.GetComponent<Button>().onClick.AddListener(birdPlayEvent);
        btnBirdFeed.GetComponent<Button>().onClick.AddListener(birdFeedEvent);
        btnBirdSleep.GetComponent<Button>().onClick.AddListener(birdSleepEvent);
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
