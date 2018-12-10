using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class ValueChange : ScriptableObject
{
    public FLoatData Data;

    public int health;

        if (health == 0)
    {
        Destroy(GameObject);
    }

    else
    {
        Debug.Log("Fnd Luke");
    }

}

void DamagePlayer(int damage)
    {
        health -= damage;
    }

    public void AddData(FLoatData Data)
    {
        Data.Value += Data.Value;
    }
    public void SubtractData(FLoatData Data)
    {
        Data.Value -= Data.Value;
    }
    
}
