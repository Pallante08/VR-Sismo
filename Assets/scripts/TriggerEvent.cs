using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gio
{
public class TriggerEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnPointerEnter;
    [SerializeField] UnityEvent OnPointerDown;
    [SerializeField] UnityEvent OnPointerUp;

        int state = 0;

    void Update()
    {
        if (state == 1)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                PointerDown();
                state = 2;
            }
        }
    }

    public void PointerEnter()
    {
        if (state == 0 || state == 3)
        {
            print("Pointer enter");
            OnPointerEnter.Invoke();
            state = 1;
        }
    }

    public void PointerDown()
    {
        //print("Pointer down");
            OnPointerDown.Invoke();

    }

    public void PointerExit()
    {
        print("Pointer exit");
        OnPointerUp.Invoke();

        if (state == 1)
        {
             state = 3;
            }else
            {
                state = 0;
            }
    }
}

}
