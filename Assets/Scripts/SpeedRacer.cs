using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;
    public int yearMade = 2009;

    public float maxAccelaration = 0.98f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    
    public class Fuel
    {
        public int fuelLevel;
        
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
        
    }

    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        print("Maker of the " + carModel + " car is " + carMaker + " and has the " + engineType + " engine.");
        CheckWeight();
        if(yearMade <= 2009){
            print("This car is made in the year " + yearMade + ".");
            int carAge = CalculateAge(yearMade);
            print("This car is " + carAge + " years old.");
        }
        else{
            print("This car was not made in the 2010's.");
            print("This car's maximum accelaration is " + maxAccelaration + ".");
        }
        print(CheckCharacteristics());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            ConsumeFuel();
            CheckFuelLevel();
        }
    }

    void CheckWeight()
    {
        if(carWeight < 1500){
            print("The" + carModel + " weights less than 1500 kg.");
        }
        else{
            print("The " + carModel + " weights more than 1500 kg.");
        }
    }

    int CalculateAge(int year)
    {
        return 2023 - year;
    }

    string CheckCharacteristics()
    {
        if(isCarTypeSedan){
            return "This car is a sedan.";
        }
        else if(hasFrontEngine){
            return "This car is not a sedan but it has a front engine.";
        }
        else{
            return "This car is not a sedan and it doesn't have a front engine.";
        }
    }

    void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }

    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                print("The fuel amount is nearing 2/3.");
                break;
            case 50:
                print("Fuel level is 1/2.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("There is nothing to report.");
                break;
        }
    }
}



