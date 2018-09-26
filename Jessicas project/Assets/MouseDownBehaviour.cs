
using UnityEngine;
using UnityEngine.Events;
//Made By Jessica Kaylor
public class MouseDownBehaviour : MonoBehaviour
{
    public UnityEvent Event;

    void OnMouseDown()
    {
        Event.Invoke();
    }
}