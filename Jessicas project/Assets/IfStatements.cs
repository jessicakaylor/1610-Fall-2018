using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made By Jessica Kaylor
public class IfStatements : MonoBehaviour
//write a script containing an if statement that compares data and have it do something.
//if something is true, it does something.
{
    public bool LightOn;
    public string Password;
    public int A, B, C;

    public FloatData WizardPower, PawnPower;
    public NameId Lock, Key;
    void Update()
    {
        if (Lock == Key) 
        {
            print("Open door.");
        }
        else
        {
            print("You cannot open the door becuase you don't have the key.");
        }
        if (LightOn)
       //if tells if something is true or not.
        {
            print("The light is on.");
        }
        else
        //else only does the opposite. 
        {
            print("The light is off.");
        }

        if (Password =="OU812")
        {
            print("You are correct!");
        }

        if (C == A+B)
        {
            print("C");
        }

        if (!LightOn)
        {
            print("Lights Off!");
        }
    }   
}
