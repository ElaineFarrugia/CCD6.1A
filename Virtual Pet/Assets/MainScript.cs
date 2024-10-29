using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type    
    Bird b; //Bird is a data type
    public Text dogInfo, birdInfo;
    public Button btnDogPlay;

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog();
        d.name = "Ginger";
        d.age = 1;
        d.happinessLevel = 5;
        d.energyLevel = 5;
        d.barkingLevel = 5;

        b = new Bird();
        b.name = "Skye";
        b.age = 4;
        b.happinessLevel = 5;
        b.energyLevel = 5;
        b.wingSpan = 20;

        btnDogPlay.GetComponent<Button>().onClick.
                                 AddListener(dogPlayEvent);
    }

    void dogPlayEvent()
    {
        d.play();
    }

    // Update is called once per frame
    void Update()
    {
        dogInfo.text = d.GetInfo(); 
        birdInfo.text = b.GetInfo();
    }
}
