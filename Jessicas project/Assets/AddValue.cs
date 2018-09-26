
using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AddValue : ScriptableObject
{
    public FLoatData ValueObj;
    public FLoatData MaxValue;
    public FLoatData MinValue;

    public UnityEvent EventMax;
    public UnityEvent EventMin;
    
    public void AddValueToObj(FLoatData data)
    {
        ValueObj.Value += data.Value;
        if (ValueObj.Value >= .MaxValue.Value)
        {
            EventMax.Invoke();
        if (ValueObj.Value <= MinValue.Value)
        {
            EventMin.Invoke();
        }

    }
}
