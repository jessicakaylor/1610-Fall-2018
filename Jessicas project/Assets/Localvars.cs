
using UnityEngine;

public class Localvars : MonoBehaviour
{

    public string Name;

    public void Call()
    {
        Name = "Bob";
        print(name);
    }

    public void Call(string newName)
    {
         print(newName);
        print(Name);
    }
    
}
