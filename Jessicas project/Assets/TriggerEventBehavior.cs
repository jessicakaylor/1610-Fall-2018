
using UnityEngine;
using UnityEngine.Events;
//Made By Jessica Kaylor
public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent Enable;
    public UnityEvent Trigger;
    
    void OnEnable()
    {
        Enable.Invoke();
    }

    void OnTriggerEnter()
    {
        Trigger.Invoke();
    }
    
}
