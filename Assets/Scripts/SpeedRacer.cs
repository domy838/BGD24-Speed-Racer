using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAccelaration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    void Start()
    {
        print("This car is " + carModel + " and has the " + engineType + " engine.");
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
}
